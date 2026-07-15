document.addEventListener('DOMContentLoaded', function () {
    const productSelect = document.getElementById('productSelect');
    const expirationFields = document.getElementById('expirationDateFields');
    const expirationInput = document.getElementById('expirationDateInput');
    const nonPerishableNote = document.getElementById('nonPerishableNote');

    if (!productSelect || !expirationFields || !expirationInput || !nonPerishableNote) return;

    function updateExpirationVisibility() {
        const selected = productSelect.options[productSelect.selectedIndex];
        const isPerishable = !selected || selected.getAttribute('data-perishable') !== 'false';

        expirationFields.style.display = isPerishable ? '' : 'none';
        nonPerishableNote.style.display = isPerishable ? 'none' : '';
        expirationInput.required = isPerishable;

        if (!isPerishable) {
            expirationInput.value = '';
        }
    }

    productSelect.addEventListener('change', updateExpirationVisibility);
    updateExpirationVisibility();
});
