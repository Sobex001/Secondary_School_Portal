document.addEventListener('DOMContentLoaded', function() {
    
    const navLinks = document.querySelectorAll('a[href^="#"]');
    
    navLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            
            const targetId = this.getAttribute('href');
            const targetSection = document.querySelector(targetId);
            
            if (targetSection) {
                const headerOffset = 80;
                const elementPosition = targetSection.getBoundingClientRect().top;
                const offsetPosition = elementPosition + window.pageYOffset - headerOffset;
                
                window.scrollTo({
                    top: offsetPosition,
                    behavior: 'smooth'
                });
            }
        });
    });
    
    // Add active state to navigation links on scroll
    window.addEventListener('scroll', function() {
        const sections = document.querySelectorAll('section[id]');
        const scrollPosition = window.pageYOffset + 100;
        
        sections.forEach(section => {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.offsetHeight;
            const sectionId = section.getAttribute('id');
            
            if (scrollPosition >= sectionTop && scrollPosition < sectionTop + sectionHeight) {
                navLinks.forEach(link => {
                    link.classList.remove('active');
                    if (link.getAttribute('href') === `#${sectionId}`) {
                        link.classList.add('active');
                    }
                });
            }
        });
    });
    
    // Animate stats counter on scroll
    const statNumbers = document.querySelectorAll('.stat-number');
    let animated = false;
    
    function animateStats() {
        if (animated) return;
        
        const statsSection = document.querySelector('.about-stats');
        if (!statsSection) return;
        
        const sectionPosition = statsSection.getBoundingClientRect().top;
        const screenPosition = window.innerHeight / 1.3;
        
        if (sectionPosition < screenPosition) {
            animated = true;
            
            statNumbers.forEach(stat => {
                const target = stat.textContent;
                const isPercentage = target.includes('%');
                const isPlusSign = target.includes('+');
                const numericValue = parseInt(target.replace(/\D/g, ''));
                
                let count = 0;
                const increment = numericValue / 50;
                const duration = 2000;
                const stepTime = duration / 50;
                
                const counter = setInterval(() => {
                    count += increment;
                    
                    if (count >= numericValue) {
                        count = numericValue;
                        clearInterval(counter);
                    }
                    
                    let displayValue = Math.floor(count);
                    
                    if (isPlusSign) {
                        displayValue += '+';
                    }
                    if (isPercentage) {
                        displayValue += '%';
                    }
                    
                    stat.textContent = displayValue;
                }, stepTime);
            });
        }
    }
    
    window.addEventListener('scroll', animateStats);
    animateStats(); // Check on load
    
    // Add scroll animation for feature cards
    const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -50px 0px'
    };
    
    const observer = new IntersectionObserver(function(entries) {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.opacity = '0';
                entry.target.style.transform = 'translateY(20px)';
                
                setTimeout(() => {
                    entry.target.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
                    entry.target.style.opacity = '1';
                    entry.target.style.transform = 'translateY(0)';
                }, 100);
                
                observer.unobserve(entry.target);
            }
        });
    }, observerOptions);
    
    // Observe portal features
    const portalFeatures = document.querySelectorAll('.portal-feature');
    portalFeatures.forEach((feature, index) => {
        feature.style.transitionDelay = `${index * 0.1}s`;
        observer.observe(feature);
    });
    
    // Observe contact items
    const contactItems = document.querySelectorAll('.contact-item');
    contactItems.forEach((item, index) => {
        item.style.transitionDelay = `${index * 0.1}s`;
        observer.observe(item);
    });
    
    // Header scroll effect
    const header = document.querySelector('.header');
    let lastScroll = 0;
    
    window.addEventListener('scroll', function() {
        const currentScroll = window.pageYOffset;
        
        if (currentScroll > 100) {
            header.style.boxShadow = '0 4px 20px rgba(0, 0, 0, 0.15)';
        } else {
            header.style.boxShadow = '0 2px 10px rgba(0, 0, 0, 0.1)';
        }
        
        lastScroll = currentScroll;
    });
    
    // Mobile menu toggle (if needed in future)
    const mobileMenuBtn = document.querySelector('.mobile-menu-btn');
    const mainNav = document.querySelector('.main-nav');
    
    if (mobileMenuBtn) {
        mobileMenuBtn.addEventListener('click', function() {
            mainNav.classList.toggle('active');
            this.classList.toggle('active');
        });
    }
    
    // Social links tracking (optional - for analytics)
    const socialLinks = document.querySelectorAll('.social-link');
    
    socialLinks.forEach(link => {
        link.addEventListener('click', function() {
            const platform = this.getAttribute('title');
            console.log(`Social link clicked: ${platform}`);
            // You can add analytics tracking here
        });
    });
    
    // Form validation for contact section (if form is added later)
    const contactForm = document.querySelector('#contactForm');
    
    if (contactForm) {
        contactForm.addEventListener('submit', function(e) {
            e.preventDefault();
            
            const formData = new FormData(this);
            const data = Object.fromEntries(formData);
            
            // Validate form fields
            let isValid = true;
            const requiredFields = this.querySelectorAll('[required]');
            
            requiredFields.forEach(field => {
                if (!field.value.trim()) {
                    isValid = false;
                    field.classList.add('error');
                } else {
                    field.classList.remove('error');
                }
            });
            
            if (isValid) {
                console.log('Form data:', data);
                // Submit form data here
                alert('Thank you for your message! We will get back to you soon.');
                this.reset();
            } else {
                alert('Please fill in all required fields.');
            }
        });
    }
    
    // Add entrance animation to hero section
    const heroContent = document.querySelector('.hero-content');
    if (heroContent) {
        heroContent.style.opacity = '0';
        heroContent.style.transform = 'translateY(30px)';
        
        setTimeout(() => {
            heroContent.style.transition = 'opacity 1s ease, transform 1s ease';
            heroContent.style.opacity = '1';
            heroContent.style.transform = 'translateY(0)';
        }, 200);
    }
    
    // Lazy load images (if needed)
    const images = document.querySelectorAll('img[data-src]');
    
    const imageObserver = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                const img = entry.target;
                img.src = img.dataset.src;
                img.removeAttribute('data-src');
                imageObserver.unobserve(img);
            }
        });
    });
    
    images.forEach(img => imageObserver.observe(img));
    
    // Add year to copyright automatically
    const copyrightYear = document.querySelector('.copyright-year');
    if (copyrightYear) {
        copyrightYear.textContent = new Date().getFullYear();
    }
    
    // Performance optimization: Debounce scroll events
    function debounce(func, wait) {
        let timeout;
        return function executedFunction(...args) {
            const later = () => {
                clearTimeout(timeout);
                func(...args);
            };
            clearTimeout(timeout);
            timeout = setTimeout(later, wait);
        };
    }
    
    // Apply debounce to scroll-heavy functions
    const debouncedAnimateStats = debounce(animateStats, 100);
    window.addEventListener('scroll', debouncedAnimateStats);
    
    console.log('Landing page initialized successfully');
});