document.addEventListener('DOMContentLoaded', function () {
    const modal = document.getElementById('productModal');
    const modalTitle = document.getElementById('productModalTitle');
    const modalBody = document.getElementById('productModalBody');
    const modalClose = document.getElementById('productModalClose');

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

    // Attach to product cards
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

                    const rows = data.map(function(s) {
                        const exp = new Date(s.expirationDate).toLocaleDateString();
                        const locationBadge = s.location === 'OnFloor' 
                            ? '<span class="badge bg-success">On Sales Floor</span>' 
                            : '<span class="badge bg-info">In Storage</span>';
                        return '<tr><td>' + s.shipmentNumber + '</td><td>' + exp + '</td><td>' + s.quantity + '</td><td>' + locationBadge + '</td></tr>';
                    }).join('');

                    if (modalBody) {
                        modalBody.innerHTML = '<table class="table table-sm"><thead><tr><th>Shipment Number</th><th>Expiration Date</th><th>Quantity</th><th>Location</th></tr></thead><tbody>' + rows + '</tbody></table>';
                    }
                })
                .catch(function(err) {
                    console.error('Error loading shipments:', err);
                    if (modalBody) modalBody.innerHTML = '<p class="text-danger">Failed to load shipments.</p>';
                });
        });
    });
});
