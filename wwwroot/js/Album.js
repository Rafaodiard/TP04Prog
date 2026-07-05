



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