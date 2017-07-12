


document.querySelector('.form-signin').addEventListener('submit', function (event) {
    event.preventDefault();
    var escopo = document.querySelector('#inputEmail');

    console.log(escopo.value);
    if (escopo.value === "aluno@email.com") {
        window.location = "aluno.html";
    } else {
        if (escopo.value == "coordenador@email.com") {
            window.location = "coordenador.html";
        } else {
            if (escopo.value == "monitor@email.com") {
                window.location = "monitor.html";
            } else {
                if (escopo.value == "professor@email.com") {
                    window.location = "professor.html";
                } else {
                    alert("Login não cadastrado. Entre em contato com o coordenador do seu curso.");
                    var email = document.querySelector('#inputEmail');
                    var senha = document.querySelector('#inputPassword');

                    email.value = "Email";
                    email.focus();
                    senha.value = "Senha"
                }
            }
        }
    }


});
