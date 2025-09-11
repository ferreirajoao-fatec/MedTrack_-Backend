const triggers = document.querySelectorAll('.accordion-trigger');

function toggleAccordion(btn) {
    const expanded = btn.getAttribute('aria-expanded') === 'true';
    const panel = document.getElementById(btn.getAttribute('aria-controls'));
    btn.setAttribute('aria-expanded', String(!expanded));

    if (!expanded) {
        panel.style.maxHeight = panel.scrollHeight + 'px';
    } else {
        panel.style.maxHeight = 0;
    }
}

function initAccordion() {
    triggers.forEach(btn => {
        const panel = document.getElementById(btn.getAttribute('aria-controls'));
        if (btn.getAttribute('aria-expanded') === 'true') {
            panel.style.maxHeight = panel.scrollHeight + 'px';
        }

        btn.addEventListener('click', () => toggleAccordion(btn));

        btn.addEventListener('keydown', e => {
            if (e.key === 'Enter' || e.key === ' ') {
                e.preventDefault();
                btn.click();
            }
        });
    });
}

window.addEventListener('load', initAccordion);
window.addEventListener('resize', () => {
    document.querySelectorAll('.panel').forEach(panel => {
        const btn = document.querySelector(`[aria-controls="${panel.id}"]`);
        if (btn && btn.getAttribute('aria-expanded') === 'true') {
            panel.style.maxHeight = panel.scrollHeight + 'px';
        }
    });
});