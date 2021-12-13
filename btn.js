const btnMenu = document.querySelector('#btn-mobile');

function toggleMenu(){
    const nav = document.querySelector('.navigation');
    nav.classList.toggle('active');
}
btnMenu.addEventListener('click', toggleMenu);
