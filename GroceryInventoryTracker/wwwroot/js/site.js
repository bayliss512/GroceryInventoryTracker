// Posts form-urlencoded data to a Razor Pages handler with the antiforgery token attached,
// for AJAX mutations that don't go through a real <form> submit. Returns the parsed JSON body
// on success and throws (with the body's "error" message, if any) otherwise.
function postWithAntiForgery(url, data) {
    var token = document.querySelector('input[name="__RequestVerificationToken"]');
    var params = new URLSearchParams(data || {});
    if (token) params.set('__RequestVerificationToken', token.value);

    return fetch(url, {
        method: 'POST',
        headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
        body: params.toString()
    }).then(function (resp) {
        return resp.json().catch(function () { return {}; }).then(function (body) {
            if (!resp.ok) throw new Error(body.error || 'Request failed.');
            return body;
        });
    });
}

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
    let pendingCallback = null;

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
        pendingCallback = null;
    }

    // Programmatic use of the same confirm modal for non-form actions (e.g. an AJAX delete
    // triggered by a plain button), so every destructive action shares one confirm UI.
    window.showConfirmModal = function (message, onConfirm) {
        pendingCallback = onConfirm;
        openConfirmModal(message);
    };

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
            if (pendingCallback) {
                const callback = pendingCallback;
                closeConfirmModal();
                callback();
                return;
            }

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
