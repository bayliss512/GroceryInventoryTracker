// Site-wide behaviors: a styled confirmation modal for destructive form submits
// (data-confirm="message" on a <form>) and a loading indicator on submit buttons,
// so users get feedback and can't double-submit while a write is in flight.
document.addEventListener('DOMContentLoaded', function () {
    const confirmModal = document.getElementById('confirmModal');
    const confirmMessage = document.getElementById('confirmModalMessage');
    const confirmAccept = document.getElementById('confirmModalAccept');
    const confirmCancel = document.getElementById('confirmModalCancel');
    const confirmClose = document.getElementById('confirmModalClose');
    let pendingForm = null;

    function openConfirmModal(message) {
        if (!confirmModal) return;
        confirmMessage.textContent = message;
        confirmModal.classList.add('open');
        document.body.style.overflow = 'hidden';
    }

    function closeConfirmModal() {
        if (!confirmModal) return;
        confirmModal.classList.remove('open');
        document.body.style.overflow = '';
        pendingForm = null;
    }

    function setFormLoading(form, submitter) {
        const btn = submitter || form.querySelector('button[type="submit"], input[type="submit"]');
        if (!btn || btn.disabled) return;

        btn.disabled = true;
        const loadingText = btn.getAttribute('data-loading-text') || 'Working…';
        if (btn.tagName === 'BUTTON') {
            btn.innerHTML = '<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span> ' + loadingText;
        } else {
            btn.value = loadingText;
        }
    }

    // Capture phase so we can intercept before any other submit listeners (e.g. inventory.js) run.
    document.addEventListener('submit', function (e) {
        const form = e.target;
        if (!(form instanceof HTMLFormElement)) return;

        const message = form.getAttribute('data-confirm');
        if (message && form.dataset.confirmed !== 'true') {
            e.preventDefault();
            pendingForm = form;
            openConfirmModal(message);
            return;
        }

        setFormLoading(form, e.submitter);
    }, true);

    if (confirmAccept) {
        confirmAccept.addEventListener('click', function () {
            if (!pendingForm) return;
            const form = pendingForm;
            closeConfirmModal();
            form.dataset.confirmed = 'true';
            if (form.requestSubmit) {
                form.requestSubmit();
            } else {
                form.submit();
            }
            delete form.dataset.confirmed;
        });
    }

    if (confirmCancel) confirmCancel.addEventListener('click', closeConfirmModal);
    if (confirmClose) confirmClose.addEventListener('click', closeConfirmModal);

    document.addEventListener('click', function (e) {
        if (e.target === confirmModal) closeConfirmModal();
    });

    document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape') closeConfirmModal();
    });
});
