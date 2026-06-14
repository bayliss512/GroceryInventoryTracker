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

    modalClose?.addEventListener('click', function () {
        closeModal();
    });

    // Attach to product rows
    document.querySelectorAll('.product-row').forEach(row => {
        row.addEventListener('click', async function () {
            const id = row.getAttribute('data-product-id');
            const name = row.getAttribute('data-product-name');
            if (!id) return;
            modalTitle!.textContent = name || 'Product Details';
            modalBody!.innerHTML = '<p class="muted">Loading shipments...</p>';
            openModal();

            try {
                const resp = await fetch(`/Index?handler=Shipments&productId=${id}`);
                if (!resp.ok) throw new Error('Network error');
                const data = await resp.json();
                if (!Array.isArray(data) || data.length === 0) {
                    modalBody!.innerHTML = '<p>No shipments available.</p>';
                    return;
                }

                const rows = data.map(s => {
                    const exp = new Date(s.expirationDate).toLocaleDateString();
                    return `<tr><td>${s.shipmentNumber}</td><td>${exp}</td><td>${s.quantity}</td></tr>`;
                }).join('');

                modalBody!.innerHTML = `
                    <table class="table table-sm">
                        <thead>
                            <tr><th>Shipment Number</th><th>Expiration Date</th><th>Quantity</th></tr>
                        </thead>
                        <tbody>
                            ${rows}
                        </tbody>
                    </table>
                `;
            } catch (err) {
                modalBody!.innerHTML = '<p class="text-danger">Failed to load shipments.</p>';
            }
        });
    });
});
