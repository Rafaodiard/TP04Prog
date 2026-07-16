document.addEventListener("DOMContentLoaded", function ()
{
    const contra1 = document.getElementById("contra1");
    const contra2 = document.getElementById("contra2");
    const formRegister = document.getElementById("formRegister");
    const errorMessage = document.getElementById("errorMessage");
    const user = document.getElementById("user");

    let usuarioDisponible = true;

    if(user)
    {
        user.addEventListener("blur", comprobarUser);
    }

    if(formRegister)
    {
        formRegister.addEventListener("submit", function(e)
        {
            if(contra1.value != contra2.value)
            {
                e.preventDefault();
                errorMessage.textContent = "Las contraseñas no coinciden";
                return;
            }

            if(!usuarioDisponible)
            {
                e.preventDefault();
                errorMessage.textContent = "Ese usuario ya existe";
                return;
            }

            errorMessage.textContent = "";
        });
    }

    async function comprobarUser()
    {
        const respuesta = await fetch("/Account/CheckUser",
        {
            method: "POST",
            headers:
            {
                "Content-Type":"application/json"
            },
            body: JSON.stringify(
            {
                NombreUsuario: user.value
            })
        });

        if(respuesta.ok)
        {
            const existe = await respuesta.json();

            if(existe)
            {
                usuarioDisponible = false;
                errorMessage.textContent = "Ese usuario ya existe";
            }
            else
            {
                usuarioDisponible = true;
                errorMessage.textContent = "";
            }
        }
    }
});