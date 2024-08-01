var nome = document.getElementById('nome');
var cor = document.querySelector('#cor');
var botao = document.querySelector('#btn');
var titulo = document.querySelector('#titulo');

botao.addEventListener('click', function(e){

    e.preventDefault();
    alert("Bem Vindo "+nome.value);
});

cor.addEventListener('change', function(){
    //alert(cor.value);
    document.body.style.backgroundColor = cor.value;
    //mudar fundo.
    document.body.style.color = "#fff"
    //mudar cor letra.
});

window.onload = function(){
    var corfav = prompt("Qual sua cor favorita?");
    var px = prompt("Digite um valor de posição eixo X");
    var py = prompt("Digite um valor de posição eixo Y");

    var alvo = document.querySelector('#alvo');
    //mudar cor alvo.
    alvo.style.backgroundColor = corfav
    //move bolinha para direita.
    alvo.style.marginLeft = px + "vw";
    //move bolinha para baixo.
    alvo.style.marginTop = py + "vh";
}