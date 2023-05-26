var user = document.getElementById("usurname");
var pass = document.getElementById("password");
var erro = document.getElementById("error");

var form = document.getElementById("valForm");

form.addEventListener("submit", function (evt) {
    evt.preventDefault();
    let errores = [];
    if (user.value === null || user.value === "") {
        errores.push("Ingrese Usuario");
    }
    if (pass.value == null || user.value === "") {
        errores.push("Ingrese Password");
    }
    erro.innerHTML = errores.join(", ");
});



