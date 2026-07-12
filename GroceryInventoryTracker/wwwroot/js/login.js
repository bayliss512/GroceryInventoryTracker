document.addEventListener('DOMContentLoaded', function () {
    const modal = document.getElementById('loginModal');
    const modalClose = document.getElementById('loginModalClose');
    const loginButton = document.getElementById('loginButton');

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

    if (loginButton) {
        loginButton.addEventListener('click', function () {
            openModal();
        });
    }

    // Show/hide password toggle (delegated so it also works inside the login modal)
    document.addEventListener('click', function (e) {
        const toggle = e.target.closest('.password-toggle');
        if (!toggle) return;

        const input = document.getElementById(toggle.dataset.target);
        if (!input) return;

        const isHidden = input.type === 'password';
        input.type = isHidden ? 'text' : 'password';
        toggle.setAttribute('aria-pressed', String(isHidden));
        toggle.setAttribute('aria-label', isHidden ? 'Hide password' : 'Show password');
        toggle.querySelector('.icon-eye').style.display = isHidden ? 'none' : '';
        toggle.querySelector('.icon-eye-slash').style.display = isHidden ? '' : 'none';
    });
});
