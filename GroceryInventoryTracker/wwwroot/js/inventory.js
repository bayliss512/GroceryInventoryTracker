document.addEventListener('DOMContentLoaded', function () {
    const modal = document.getElementById('productModal');
    const modalTitle = document.getElementById('productModalTitle');
    const modalBody = document.getElementById('productModalBody');
    const modalClose = document.getElementById('productModalClose');
    const searchResults = document.getElementById('searchResults');
    const qrPrintArea = document.getElementById('qrPrintArea');
    const canManageShipments = modal && modal.getAttribute('data-can-manage-shipments') === 'true';
    const canDeleteShipments = modal && modal.getAttribute('data-can-delete-shipments') === 'true';

    // Debounced live search: fetch just the results partial and swap it in, so the page
    // no longer does a full reload while the user is still typing. The Search button and
    // Enter key still work via the form's normal submit for a full navigation/bookmarkable URL.
    const searchInput = document.getElementById('searchInput');
    if (searchInput && searchResults) {
        let debounceTimer;
        let latestRequestId = 0;

        searchInput.addEventListener('input', function () {
            clearTimeout(debounceTimer);
            debounceTimer = setTimeout(function () {
                runLiveSearch();
            }, 400);
        });

        function runLiveSearch() {
            const form = searchInput.form;
            const params = new URLSearchParams(new FormData(form));
            const requestId = ++latestRequestId;
            // form.action reflects the document's current URL (including any existing query
            // string) when the <form> has no action attribute, so strip it before appending ours.
            const actionUrl = form.action.split('?')[0];

            fetch(actionUrl + '?handler=Results&' + params.toString())
                .then(function (resp) {
                    if (!resp.ok) throw new Error('Network error');
                    return resp.text();
                })
                .then(function (html) {
                    // Ignore stale responses that resolve out of order
                    if (requestId !== latestRequestId) return;
                    searchResults.innerHTML = html;
                    bindProductCards();

                    const newUrl = window.location.pathname + '?' + params.toString();
                    window.history.replaceState(null, '', newUrl);
                })
                .catch(function (err) {
                    console.error('Error updating search results:', err);
                });
        }
    }

    function openModal() {
        if (!modal) return;
        modal.classList.add('open');
        document.body.style.overflow = 'hidden';
    }

    function closeModal() {
        if (!modal) return;
        modal.classList.remove('open');
        document.body.style.overflow = '';
    }

    // Close on backdrop click
    document.addEventListener('click', function (e) {
        if (!modal) return;
        if (e.target === modal) {
            closeModal();
        }
    });

    // Close on Escape
    document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape') {
            closeModal();
        }
    });

    if (modalClose) {
        modalClose.addEventListener('click', function () {
            closeModal();
        });
    }

    // Shared formatting so the shipment list, the QR/detail view, and the scanner result all
    // render expiration and location the same way.
    function formatExpiration(expirationDate) {
        if (!expirationDate) return { display: '—', badge: '' };

        const EXPIRING_SOON_DAYS = 7;
        const now = new Date();
        const startOfToday = new Date(now.getFullYear(), now.getMonth(), now.getDate());

        const expDate = new Date(expirationDate);
        const display = expDate.toLocaleDateString();

        const expDay = new Date(expDate.getFullYear(), expDate.getMonth(), expDate.getDate());
        const daysUntilExpiry = Math.round((expDay - startOfToday) / 86400000);

        let badge = '';
        if (daysUntilExpiry < 0) {
            badge = ' <span class="badge bg-danger">Expired</span>';
        } else if (daysUntilExpiry <= EXPIRING_SOON_DAYS) {
            const label = daysUntilExpiry === 0
                ? 'Expires today'
                : 'Expires in ' + daysUntilExpiry + ' day' + (daysUntilExpiry === 1 ? '' : 's');
            badge = ' <span class="badge bg-warning text-dark">' + label + '</span>';
        }

        return { display: display, badge: badge };
    }

    function formatLocation(location) {
        const display = location === 'OnFloor' ? 'On Sales Floor' : 'In Storage';
        const badge = location === 'OnFloor'
            ? '<span class="badge bg-success">On Sales Floor</span>'
            : '<span class="badge bg-info">In Storage</span>';
        return { display: display, badge: badge };
    }

    // Renders a shipment's QR code (encoding the shipment number) plus its details inside the
    // product modal. Includes quick-action buttons (move to floor/storage, delete) when the
    // signed-in user is allowed to use them, a print button, and a back/close control.
    // `options.onBack`, if given, returns to the shipment list for the product instead of
    // closing the modal (used when opened by clicking a row rather than the QR scanner).
    function showShipmentQr(shipment, productName, options) {
        options = options || {};

        const qr = qrcode(0, 'M');
        qr.addData(shipment.shipmentNumber);
        qr.make();
        const qrSvg = qr.createSvgTag({ cellSize: 5, margin: 4 });

        const detailsHtml =
            '<table class="table table-sm qr-details-table">' +
            '<tr><th>Product</th><td>' + (productName || '—') + '</td></tr>' +
            '<tr><th>Shipment Number</th><td>' + shipment.shipmentNumber + '</td></tr>' +
            '<tr><th>Expiration Date</th><td>' + shipment.expirationDisplay + '</td></tr>' +
            '<tr><th>Quantity</th><td>' + shipment.quantity + '</td></tr>' +
            '<tr><th>Location</th><td>' + shipment.locationDisplay + '</td></tr>' +
            '</table>';

        let actionButtons = '';
        if (canManageShipments) {
            if (shipment.location !== 'OnFloor') {
                actionButtons += '<button type="button" class="btn btn-outline-success btn-sm" id="qrMoveFloorBtn">Move to Floor</button> ';
            }
            if (shipment.location !== 'InStorage') {
                actionButtons += '<button type="button" class="btn btn-outline-info btn-sm" id="qrMoveStorageBtn">Move to Storage</button> ';
            }
        }
        if (canDeleteShipments) {
            actionButtons += '<button type="button" class="btn btn-outline-danger btn-sm" id="qrDeleteBtn">Delete</button>';
        }

        const backLabel = options.onBack ? '&larr; Back to shipments' : '&larr; Close';

        if (modalTitle) modalTitle.textContent = 'Shipment Details';
        if (modalBody) {
            modalBody.innerHTML =
                '<button type="button" class="btn btn-link ps-0 mb-2" id="qrBackBtn">' + backLabel + '</button>' +
                '<div id="qrActionError" class="alert alert-danger py-2 d-none" role="alert"></div>' +
                '<div class="qr-view text-center">' +
                '<div class="qr-code-wrap mb-3">' + qrSvg + '</div>' +
                detailsHtml +
                '</div>' +
                (actionButtons ? '<div class="d-flex justify-content-center flex-wrap gap-2 mt-3">' + actionButtons + '</div>' : '') +
                '<div class="text-end mt-3">' +
                '<button type="button" class="btn btn-primary" id="qrPrintBtn"><svg class="icon"><use href="#icon-printer"></use></svg>Print</button>' +
                '</div>';
        }

        function showActionError(message) {
            const errorBox = document.getElementById('qrActionError');
            if (!errorBox) return;
            errorBox.textContent = message;
            errorBox.classList.remove('d-none');
        }

        const backBtn = document.getElementById('qrBackBtn');
        if (backBtn) {
            backBtn.addEventListener('click', function () {
                if (options.onBack) {
                    options.onBack();
                } else {
                    closeModal();
                }
            });
        }

        const moveFloorBtn = document.getElementById('qrMoveFloorBtn');
        if (moveFloorBtn) {
            moveFloorBtn.addEventListener('click', function () {
                postWithAntiForgery('/Index?handler=SetShipmentLocation', { id: shipment.id, location: 'OnFloor' })
                    .then(function () {
                        shipment.location = 'OnFloor';
                        shipment.locationDisplay = formatLocation('OnFloor').display;
                        showShipmentQr(shipment, productName, options);
                    })
                    .catch(function (err) { showActionError(err.message); });
            });
        }

        const moveStorageBtn = document.getElementById('qrMoveStorageBtn');
        if (moveStorageBtn) {
            moveStorageBtn.addEventListener('click', function () {
                postWithAntiForgery('/Index?handler=SetShipmentLocation', { id: shipment.id, location: 'InStorage' })
                    .then(function () {
                        shipment.location = 'InStorage';
                        shipment.locationDisplay = formatLocation('InStorage').display;
                        showShipmentQr(shipment, productName, options);
                    })
                    .catch(function (err) { showActionError(err.message); });
            });
        }

        const deleteBtn = document.getElementById('qrDeleteBtn');
        if (deleteBtn) {
            deleteBtn.addEventListener('click', function () {
                if (typeof window.showConfirmModal !== 'function') return;
                window.showConfirmModal('Delete shipment "' + shipment.shipmentNumber + '"? This cannot be undone.', function () {
                    postWithAntiForgery('/Index?handler=DeleteShipment', { id: shipment.id })
                        .then(function () {
                            closeModal();
                        })
                        .catch(function (err) { showActionError(err.message); });
                });
            });
        }

        const printBtn = document.getElementById('qrPrintBtn');
        if (printBtn) {
            printBtn.addEventListener('click', function () {
                if (!qrPrintArea) return;
                qrPrintArea.innerHTML =
                    '<h2>' + (productName || '') + '</h2>' +
                    '<div class="qr-code-wrap">' + qrSvg + '</div>' +
                    detailsHtml;
                document.body.classList.add('printing-qr');
                window.print();
            });
        }
    }

    // Wires up click handlers on each shipment row in the currently rendered list so clicking
    // one shows its details, with a back button that returns to a freshly reloaded list.
    function bindShipmentRows(productId, productName) {
        if (!modalBody) return;
        modalBody.querySelectorAll('.shipment-row').forEach(function (row) {
            row.addEventListener('click', function () {
                showShipmentQr({
                    id: row.getAttribute('data-shipment-id'),
                    shipmentNumber: row.getAttribute('data-shipment-number'),
                    expirationDisplay: row.getAttribute('data-expiration-display'),
                    quantity: row.getAttribute('data-quantity'),
                    location: row.getAttribute('data-location'),
                    locationDisplay: row.getAttribute('data-location-display')
                }, productName, {
                    onBack: function () { loadShipmentsForProduct(productId, productName); }
                });
            });
        });
    }

    // The print dialog closes (printed or cancelled) - restore the normal page view.
    window.addEventListener('afterprint', function () {
        document.body.classList.remove('printing-qr');
        if (qrPrintArea) qrPrintArea.innerHTML = '';
    });

    function renderShipmentRow(s) {
        const exp = formatExpiration(s.expirationDate);
        const loc = formatLocation(s.location);
        return '<tr class="shipment-row" data-shipment-id="' + s.id + '" data-shipment-number="' + s.shipmentNumber + '" data-expiration-display="' + exp.display + '" data-quantity="' + s.quantity + '" data-location="' + s.location + '" data-location-display="' + loc.display + '">' +
            '<td>' + s.shipmentNumber + '</td><td>' + exp.display + exp.badge + '</td><td>' + s.quantity + '</td><td>' + loc.badge + '</td></tr>';
    }

    // Loads (or reloads) the shipment list for a product into the modal. Used both for the
    // initial product-card click and to refresh the list after a quick action changes it.
    function loadShipmentsForProduct(productId, productName) {
        if (modalTitle) modalTitle.textContent = productName || 'Product Details';
        if (modalBody) modalBody.innerHTML = '<p class="muted">Loading shipments...</p>';
        openModal();

        fetch('/Index?handler=Shipments&productId=' + productId)
            .then(function (resp) {
                if (!resp.ok) throw new Error('Network error');
                return resp.json();
            })
            .then(function (data) {
                if (!Array.isArray(data) || data.length === 0) {
                    if (modalBody) modalBody.innerHTML = '<p>No shipments available.</p>';
                    return;
                }

                const rows = data.map(renderShipmentRow).join('');
                const shipmentListHtml = '<p class="text-muted small mb-2">Click a shipment to view and edit its details.</p>' +
                    '<table class="table table-sm"><thead><tr><th>Shipment Number</th><th>Expiration Date</th><th>Quantity</th><th>Location</th></tr></thead><tbody>' + rows + '</tbody></table>';

                if (modalBody) modalBody.innerHTML = shipmentListHtml;
                bindShipmentRows(productId, productName);
            })
            .catch(function (err) {
                console.error('Error loading shipments:', err);
                if (modalBody) modalBody.innerHTML = '<p class="text-danger">Failed to load shipments.</p>';
            });
    }

    // Attach to product cards. Called on load and again after live-search swaps in new cards.
    function bindProductCards() {
        document.querySelectorAll('.product-card').forEach(function (card) {
            card.addEventListener('click', function () {
                const id = card.getAttribute('data-product-id');
                const name = card.getAttribute('data-product-name');
                if (!id) return;

                loadShipmentsForProduct(id, name);
            });
        });
    }

    // --- QR code scanner: looks up a shipment by scanning its printed/displayed QR code
    // (which encodes the shipment number) and opens the same detail view as clicking a row. ---
    const scanBtn = document.getElementById('scanQrBtn');
    const scannerModal = document.getElementById('scannerModal');
    const scannerModalClose = document.getElementById('scannerModalClose');
    const scannerVideo = document.getElementById('scannerVideo');
    const scannerError = document.getElementById('scannerError');
    let scannerStream = null;
    let scannerFrameRequest = null;
    let scannerCanvas = null;

    function showScannerError(message) {
        if (!scannerError) return;
        scannerError.textContent = message;
        scannerError.classList.remove('d-none');
    }

    function hideScannerError() {
        if (!scannerError) return;
        scannerError.classList.add('d-none');
    }

    function openScannerModal() {
        if (!scannerModal) return;
        scannerModal.classList.add('open');
        document.body.style.overflow = 'hidden';
    }

    function closeScannerModal() {
        if (!scannerModal) return;
        scannerModal.classList.remove('open');
        document.body.style.overflow = '';
        stopScanning();
    }

    function stopScanning() {
        if (scannerFrameRequest) {
            cancelAnimationFrame(scannerFrameRequest);
            scannerFrameRequest = null;
        }
        if (scannerStream) {
            scannerStream.getTracks().forEach(function (track) { track.stop(); });
            scannerStream = null;
        }
        if (scannerVideo) scannerVideo.srcObject = null;
    }

    function scanFrame() {
        if (!scannerStream || !scannerVideo || typeof jsQR !== 'function') return;

        if (scannerVideo.readyState === scannerVideo.HAVE_ENOUGH_DATA) {
            if (!scannerCanvas) scannerCanvas = document.createElement('canvas');
            scannerCanvas.width = scannerVideo.videoWidth;
            scannerCanvas.height = scannerVideo.videoHeight;
            const ctx = scannerCanvas.getContext('2d');
            ctx.drawImage(scannerVideo, 0, 0, scannerCanvas.width, scannerCanvas.height);
            const imageData = ctx.getImageData(0, 0, scannerCanvas.width, scannerCanvas.height);
            const code = jsQR(imageData.data, imageData.width, imageData.height);

            if (code && code.data) {
                closeScannerModal();
                lookupAndShowShipment(code.data);
                return;
            }
        }

        scannerFrameRequest = requestAnimationFrame(scanFrame);
    }

    function startScanning() {
        hideScannerError();
        openScannerModal();

        if (!navigator.mediaDevices || !navigator.mediaDevices.getUserMedia) {
            showScannerError('Camera access is not supported in this browser.');
            return;
        }

        navigator.mediaDevices.getUserMedia({ video: { facingMode: 'environment' } })
            .then(function (stream) {
                scannerStream = stream;
                if (scannerVideo) {
                    scannerVideo.srcObject = stream;
                    scannerVideo.play();
                }
                scannerFrameRequest = requestAnimationFrame(scanFrame);
            })
            .catch(function () {
                showScannerError('Camera access is required to scan a QR code.');
            });
    }

    function lookupAndShowShipment(shipmentNumber) {
        fetch('/Index?handler=ShipmentByNumber&shipmentNumber=' + encodeURIComponent(shipmentNumber))
            .then(function (resp) {
                return resp.json().catch(function () { return {}; }).then(function (body) {
                    if (!resp.ok) throw new Error(body.error || 'Shipment not found.');
                    return body;
                });
            })
            .then(function (s) {
                openModal();
                showShipmentQr({
                    id: s.id,
                    shipmentNumber: s.shipmentNumber,
                    expirationDisplay: formatExpiration(s.expirationDate).display,
                    quantity: s.quantity,
                    location: s.location,
                    locationDisplay: formatLocation(s.location).display
                }, s.productName, {});
            })
            .catch(function (err) {
                startScanning();
                showScannerError(err.message);
            });
    }

    if (scanBtn) {
        scanBtn.addEventListener('click', startScanning);
    }
    if (scannerModalClose) {
        scannerModalClose.addEventListener('click', closeScannerModal);
    }
    if (scannerModal) {
        scannerModal.addEventListener('click', function (e) {
            if (e.target === scannerModal) closeScannerModal();
        });
    }
    document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape' && scannerModal && scannerModal.classList.contains('open')) {
            closeScannerModal();
        }
    });

    bindProductCards();
});
