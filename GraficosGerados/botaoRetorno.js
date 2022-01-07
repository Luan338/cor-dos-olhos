const anterior = document.querySelector('#anterior');

function retornarPag(){
    window.location.replace('../index.html');
}
anterior.addEventListener('click', retornarPag);