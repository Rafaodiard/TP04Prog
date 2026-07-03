



    const contra1 = document.getElementById("contra1");
    const contra2 = document.getElementById("contra2");
    if (contra1.value != contra2.value)
    {
        e.preventDefault();
        alert("las contraseñas no coinciden");
    }
