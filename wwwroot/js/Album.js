const selecciones = document.querySelectorAll(".seleccion");
const botonAtras = document.getElementById("anterior");
const botonAdelante = document.getElementById("siguiente");
let indiceActual = 0;

console.log(document.querySelectorAll(".seleccion"));
console.log(document.getElementById("anterior"));
console.log(document.getElementById("siguiente"));


async function Pegar(idFigurita, button)
{
    const respuesta  = await fetch("/Album/Pegar", {
    method: "POST",
    headers: {
        "Content-Type": "application/json"
    },
    body: JSON.stringify({ idFigurita: idFigurita })
    });
    if(respuesta.ok)
    {
        console.log("Figurita pegada correctamente");
        const figurita = button.closest(".figurita");
        const imagen = figurita.querySelector("img");
        imagen.src = "/images/jugadores/" + button.dataset.imagen;
        button.remove();

    }
}
function mostrarSelecciones(indice)
{
    selecciones[indiceActual].classList.remove("activa");    
    indiceActual = indice;
    selecciones[indiceActual].classList.add("activa");
}

botonAdelante.addEventListener("click", function(e) 
    {
        let siguiente = indiceActual + 1;
        if(siguiente >= selecciones.length)
        {
            siguiente = 0;
        }
        mostrarSelecciones(siguiente);
    });
botonAtras.addEventListener("click", function(e) 
    {
        let anterior = indiceActual - 1;
        if(anterior <= 0)
        {   
            anterior = selecciones.length - 1;
        }
        mostrarSelecciones(anterior);
    });