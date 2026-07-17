document.addEventListener('DOMContentLoaded', function () {
    const modal = document.getElementById('productModal');
    const modalTitle = document.getElementById('productModalTitle');
    const modalBody = document.getElementById('productModalBody');
    const modalClose = document.getElementById('productModalClose');
    const searchResults = document.getElementById('searchResults');
    const qrPrintArea = document.getElementById('qrPrintArea');

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

    // Renders a shipment's QR code (encoding the shipment number) plus its details inside
    // the product modal, with a way back to the shipment list and a button to print just this view.
    function showShipmentQr(shipment, productName, shipmentListHtml) {
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

        if (modalTitle) modalTitle.textContent = 'Shipment QR Code';
        if (modalBody) {
            modalBody.innerHTML =
                '<button type="button" class="btn btn-link ps-0 mb-2" id="qrBackBtn">&larr; Back to shipments</button>' +
                '<div class="qr-view text-center">' +
                '<div class="qr-code-wrap mb-3">' + qrSvg + '</div>' +
                detailsHtml +
                '</div>' +
                '<div class="text-end mt-3">' +
                '<button type="button" class="btn btn-primary" id="qrPrintBtn"><svg class="icon"><use href="#icon-printer"></use></svg>Print</button>' +
                '</div>';
        }

        const backBtn = document.getElementById('qrBackBtn');
        if (backBtn) {
            backBtn.addEventListener('click', function () {
                if (modalTitle) modalTitle.textContent = productName || 'Product Details';
                if (modalBody) modalBody.innerHTML = shipmentListHtml;
                bindShipmentRows(shipmentListHtml, productName);
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

    // Wires up click handlers on each shipment row so clicking one shows its QR code.
    function bindShipmentRows(shipmentListHtml, productName) {
        if (!modalBody) return;
        modalBody.querySelectorAll('.shipment-row').forEach(function (row) {
            row.addEventListener('click', function () {
                showShipmentQr({
                    shipmentNumber: row.getAttribute('data-shipment-number'),
                    expirationDisplay: row.getAttribute('data-expiration-display'),
                    quantity: row.getAttribute('data-quantity'),
                    locationDisplay: row.getAttribute('data-location-display')
                }, productName, shipmentListHtml);
            });
        });
    }

    // The print dialog closes (printed or cancelled) - restore the normal page view.
    window.addEventListener('afterprint', function () {
        document.body.classList.remove('printing-qr');
        if (qrPrintArea) qrPrintArea.innerHTML = '';
    });

    // Attach to product cards. Called on load and again after live-search swaps in new cards.
    function bindProductCards() {
        document.querySelectorAll('.product-card').forEach(function(card) {
            card.addEventListener('click', function () {
                const id = card.getAttribute('data-product-id');
                const name = card.getAttribute('data-product-name');
                if (!id) return;

                if (modalTitle) modalTitle.textContent = name || 'Product Details';
                if (modalBody) modalBody.innerHTML = '<p class="muted">Loading shipments...</p>';
                openModal();

                fetch('/Index?handler=Shipments&productId=' + id)
                    .then(function(resp) {
                        if (!resp.ok) throw new Error('Network error');
                        return resp.json();
                    })
                    .then(function(data) {
                        if (!Array.isArray(data) || data.length === 0) {
                            if (modalBody) modalBody.innerHTML = '<p>No shipments available.</p>';
                            return;
                        }

                        const EXPIRING_SOON_DAYS = 7;
                        const now = new Date();
                        const startOfToday = new Date(now.getFullYear(), now.getMonth(), now.getDate());

                        const rows = data.map(function(s) {
                            var exp = '—';
                            var expirationBadge = '';

                            if (s.expirationDate) {
                                const expDate = new Date(s.expirationDate);
                                exp = expDate.toLocaleDateString();

                                // Compare whole days between the expiration date and the start of today
                                const expDay = new Date(expDate.getFullYear(), expDate.getMonth(), expDate.getDate());
                                const daysUntilExpiry = Math.round((expDay - startOfToday) / 86400000);

                                if (daysUntilExpiry < 0) {
                                    expirationBadge = ' <span class="badge bg-danger">Expired</span>';
                                } else if (daysUntilExpiry <= EXPIRING_SOON_DAYS) {
                                    const label = daysUntilExpiry === 0
                                        ? 'Expires today'
                                        : 'Expires in ' + daysUntilExpiry + ' day' + (daysUntilExpiry === 1 ? '' : 's');
                                    expirationBadge = ' <span class="badge bg-warning text-dark">' + label + '</span>';
                                }
                            }

                            const locationDisplay = s.location === 'OnFloor' ? 'On Sales Floor' : 'In Storage';
                            const locationBadge = s.location === 'OnFloor'
                                ? '<span class="badge bg-success">On Sales Floor</span>'
                                : '<span class="badge bg-info">In Storage</span>';
                            return '<tr class="shipment-row" data-shipment-number="' + s.shipmentNumber + '" data-expiration-display="' + exp + '" data-quantity="' + s.quantity + '" data-location-display="' + locationDisplay + '">' +
                                '<td>' + s.shipmentNumber + '</td><td>' + exp + expirationBadge + '</td><td>' + s.quantity + '</td><td>' + locationBadge + '</td></tr>';
                        }).join('');

                        const shipmentListHtml = '<p class="text-muted small mb-2">Click a shipment to view its QR code.</p>' +
                            '<table class="table table-sm"><thead><tr><th>Shipment Number</th><th>Expiration Date</th><th>Quantity</th><th>Location</th></tr></thead><tbody>' + rows + '</tbody></table>';

                        if (modalBody) {
                            modalBody.innerHTML = shipmentListHtml;
                        }
                        bindShipmentRows(shipmentListHtml, name);
                    })
                    .catch(function(err) {
                        console.error('Error loading shipments:', err);
                        if (modalBody) modalBody.innerHTML = '<p class="text-danger">Failed to load shipments.</p>';
                    });
            });
        });
    }

    bindProductCards();
});
