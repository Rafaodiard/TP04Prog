document.addEventListener("DOMContentLoaded", function() {
    const contra1 = document.getElementById("contra1");
    const contra2 = document.getElementById("contra2");
    const formRegister = document.getElementById("formRegister");
    const errorMessage = document.getElementById("errorMessage");

    if (formRegister) {
        formRegister.addEventListener("submit", function(e) {
            if (contra1.value != contra2.value) {
                e.preventDefault();
                errorMessage.textContent = "las contraseñas no coinciden";
            } else {
                errorMessage.textContent = "";
            }
        });
    }
});