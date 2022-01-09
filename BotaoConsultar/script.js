const botaoConsultar = document.querySelector('#consultar');

function newPag(){
    window.location.replace('./Consultar/index.html');
}
botaoConsultar.addEventListener('click', newPag);