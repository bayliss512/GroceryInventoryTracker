document.addEventListener('DOMContentLoaded', function () {
    const REFRESH_INTERVAL_MS = 45000;

    function escapeHtml(text) {
        const div = document.createElement('div');
        div.textContent = text;
        return div.innerHTML;
    }

    function setText(id, value) {
        const el = document.getElementById(id);
        if (el) el.textContent = value;
    }

    function renderNameList(id, names) {
        const el = document.getElementById(id);
        if (!el) return;
        el.innerHTML = names.map(function (name) {
            return '<li>' + escapeHtml(name) + '</li>';
        }).join('');
    }

    function formatDate(iso) {
        const d = new Date(iso);
        return d.toLocaleDateString(undefined, { month: 'short', day: '2-digit' });
    }

    function formatDateLong(iso) {
        const d = new Date(iso);
        return d.toLocaleDateString(undefined, { month: 'short', day: '2-digit', year: 'numeric' });
    }

    function refreshDashboard() {
        fetch('/Dashboard?handler=Data')
            .then(function (resp) {
                if (!resp.ok) throw new Error('Network error');
                return resp.json();
            })
            .then(function (data) {
                setText('stat-total-products', data.totalProducts);
                setText('stat-low-stock-count', data.lowStockCount);
                setText('stat-out-of-stock-count', data.outOfStockCount);
                setText('stat-expiring-soon-count', data.expiringSoonCount);

                renderNameList('list-low-stock', data.lowStockProducts);
                renderNameList('list-out-of-stock', data.outOfStockProducts);

                const expiringList = document.getElementById('list-expiring-soon');
                if (expiringList) {
                    expiringList.innerHTML = data.expiringSoonShipments.map(function (s) {
                        return '<li>' + escapeHtml(s.productName) + ' — ' + formatDate(s.expirationDate) + '</li>';
                    }).join('');
                }

                const shipmentsBody = document.getElementById('table-recent-shipments');
                if (shipmentsBody) {
                    shipmentsBody.innerHTML = data.recentShipments.map(function (s) {
                        return '<tr><td>' + escapeHtml(s.productName) + '</td><td>' +
                            escapeHtml(s.supplierName || '—') + '</td><td>' + s.quantity + '</td><td>' +
                            escapeHtml(s.location) + '</td><td>' + formatDateLong(s.createdAt) + '</td></tr>';
                    }).join('');
                }

                const usersBody = document.getElementById('table-recent-users');
                if (usersBody) {
                    usersBody.innerHTML = data.recentUsers.map(function (u) {
                        return '<tr><td>' + escapeHtml(u.username) + '</td><td>' + formatDateLong(u.createdAt) + '</td></tr>';
                    }).join('');
                }
            })
            .catch(function (err) {
                console.error('Error refreshing dashboard:', err);
            });
    }

    setInterval(refreshDashboard, REFRESH_INTERVAL_MS);
});
