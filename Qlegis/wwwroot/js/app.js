const btnMobile = document.getElementById('btn-mobile');

function toggleMenu(){
    const nav = document.getElementById('nav');
    nav.classList.toggle('active')
}
btnMobile.addEventListener('click', toggleMenu);

function irSobre(){
    location='sobre.html'
}

function irAjuda(){
    location='ajuda.html'
}

function irTermos(){
    location='termos.html'
}

function irDuvidas(){
    location='duvidas.html'
}

function irPlnaos(){
    location='/plano'
}

function irAjuda(){
    location='ajuda.html'
}

function faleConosco(){
    location='faleConosco.html'
}

function irLogin(){
    location='/login'
}

function btnEnvia(){
    alert('Mensagem enviada')
}

function avisoDeLogin(){
    avisoEntra.style.display='block'
}

function fechaAvisoDeLogin(){
    avisoEntra.style.display='none'
}

function avisoLink(){
    alert('Sem link')
}

/*====== link dentro da pagina ======*/
function irSobreA(){
    location='../sobre.html'
}
function irAjudaA(){
    location='../ajuda.html'
}

function irTermosA(){
    location='../termos.html'
}

function irDuvidasA(){
    location='../duvidas.html'
}

function irPlnaosA(){
    location='planos.html'
}

function irAjudaA(){
    location='../ajuda.html'
}

function faleConoscoA(){
    location='../faleConosco.html'
}

/*====== Aceso temporario ======*/

function verifiarLog(){
    const email = document.getElementById('tMail').value
    const senha = document.getElementById('tSenha').value

    if (email != "admin"  || senha != "admin3636"){
        alert('Acesso negado')
    } else {
        alert('Autorizado')
        location='../01_logado/00-inicioLogado/logado.html'
    }
}

/*====== Aceso temporario ======*/