function animacaoScroll(){
    const sections = document.querySelectorAll('.js-scroll');

    if(sections.length){
        const windowMetade = window.innerHeight * 0.5;

        function animaScroll(){
            sections.forEach((e) => {
                const sectionTop = e.getBoundingClientRect().top;
                const isSectionVisible = (sectionTop - windowMetade);

                if(isSectionVisible){
                    e.classList.add('ativo');
                }

            })
        }
        window.addEventListener('scroll', animaScroll);
    }
}
animacaoScroll();