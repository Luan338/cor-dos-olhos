const botaoRegistrar = document.querySelector('#registrar');

function newPag(){
    window.location.replace('./Registrar/index.html');
}
botaoRegistrar.addEventListener('click', newPag);