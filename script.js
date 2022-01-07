function animacaoScroll(){
    const sections = document.querySelectorAll('.js-scroll');
    
    if(sections.length){
        const windowMetade = window.innerHeight * 0.7;

        function animaScroll(){
            sections.forEach((e) => {
                const sectionTop = e.getBoundingClientRect().top;
                const isSectionVisible = (sectionTop - windowMetade) < 0;

                if(isSectionVisible){
                    e.classList.add('ativo');
                }

            })
        }
        animaScroll();
        window.addEventListener('scroll', animaScroll);
    }
}
animacaoScroll();