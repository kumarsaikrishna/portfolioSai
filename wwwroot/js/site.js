document.addEventListener('DOMContentLoaded', function () {
    // Mobile menu toggle
    const mobileMenuButton = document.querySelector('[data-mobile-menu-button]');
    const mobileMenu = document.querySelector('[data-mobile-menu]');

    if (mobileMenuButton && mobileMenu) {
        mobileMenuButton.addEventListener('click', () => {
            const isOpen = mobileMenu.getAttribute('data-open') === 'true';
            mobileMenu.setAttribute('data-open', !isOpen);
            mobileMenu.classList.toggle('hidden');
        });
    }

    // Scroll effect for header
    window.addEventListener('scroll', function () {
        const header = document.querySelector('header');
        if (window.scrollY > 50) {
            header.classList.add('bg-white/95', 'backdrop-blur-sm', 'shadow-lg');
            header.classList.remove('bg-transparent');
        } else {
            header.classList.remove('bg-white/95', 'backdrop-blur-sm', 'shadow-lg');
            header.classList.add('bg-transparent');
        }
    });

    // Form submission
    const contactForm = document.getElementById('contact-form');
    if (contactForm) {
        contactForm.addEventListener('submit', function (e) {
            e.preventDefault();

            const submitButton = contactForm.querySelector('button[type="submit"]');
            const originalButtonText = submitButton.innerHTML;

            // Show loading state
            submitButton.innerHTML = '<span class="loading">⏳</span> Sending...';
            submitButton.disabled = true;

            // Simulate form submission
            setTimeout(() => {
                // Show success message
                document.getElementById('form-success').classList.remove('hidden');

                // Reset form
                contactForm.reset();

                // Reset button
                submitButton.innerHTML = originalButtonText;
                submitButton.disabled = false;

                // Hide success message after 5 seconds
                setTimeout(() => {
                    document.getElementById('form-success').classList.add('hidden');
                }, 5000);
            }, 1500);
        });
    }
});