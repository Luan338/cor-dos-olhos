// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/*site home*/
const btnMenu = document.querySelector('#btn-mobile');

function toggleMenu() {
    const nav = document.querySelector('.navigation');
    nav.classList.toggle('active');
}
btnMenu.addEventListener('click', toggleMenu);


const verificar = document.querySelector('#verificar');

function pag() {
    window.location.replace('./GraficosGerados/index.html');
}
verificar.addEventListener('click', pag);


const saibaMais = document.querySelector('#saibaMais');

function newPag() {
    window.location.replace('./Sobre/index.html');
}
saibaMais.addEventListener('click', newPag);


function animacaoScroll() {
    const sections = document.querySelectorAll('.js-scroll');

    if (sections.length) {
        const windowMetade = window.innerHeight * 0.7;

        function animaScroll() {
            sections.forEach((e) => {
                const sectionTop = e.getBoundingClientRect().top;
                const isSectionVisible = (sectionTop - windowMetade) < 0;

                if (isSectionVisible) {
                    e.classList.add('ativo');
                }

            })
        }
        animaScroll();
        window.addEventListener('scroll', animaScroll);
    }
}
animacaoScroll();
/**fim site home*/