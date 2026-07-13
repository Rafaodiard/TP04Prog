const sobre = document.getElementById("sobre");
const imgSobre = document.getElementById("imagenSobre");
const contenedorFiguritas = document.getElementById("figuritas");
const guardarBut = document.getElementById("guardar");
async function AbrirSobre()
{
    const respuesta = await fetch("/Figuritas/AbrirSobre");
    if (respuesta.ok)
    {
        const figuritas = await respuesta.json();


        contenedorFiguritas.innerHTML = "";
        sobre.style.display = "none";   
        guardarBut.style.display = "block"


        figuritas.forEach((figurita, i) =>
        {
            setTimeout(() =>
            {
                const carta = document.createElement("div");
                carta.classList.add("carta");

                const img = document.createElement("img");
                img.src = "/images/jugadores/" + figurita.jugador.imagen;
                img.alt = figurita.jugador.nombre;

                carta.appendChild(img);

                contenedorFiguritas.appendChild(carta);

            }, i * 250);
        });
    }
}

async function GuardarFigus()
{   

    const respuesta = await fetch("/Figuritas/GuardarFiguritas",{method: "POST"});   
    if (respuesta.ok)
    {
        contenedorFiguritas.innerHTML = "";
        guardarBut.style.display = "none";
        sobre.style.display = "block";   
    }
}
async function cargarSobre()
{
    const respuesta = await fetch("/Figuritas/Cargar");
    if (respuesta.ok)
    {
        const figuritas = await respuesta.json();


        contenedorFiguritas.innerHTML = "";
        sobre.style.display = "none";   
        guardarBut.style.display = "block"


        figuritas.forEach((figurita, i) =>
        {
            setTimeout(() =>
            {
                const carta = document.createElement("div");
                carta.classList.add("carta");

                const img = document.createElement("img");
                img.src = "/images/jugadores/" + figurita.jugador.imagen;
                img.alt = figurita.jugador.nombre;

                carta.appendChild(img);

                contenedorFiguritas.appendChild(carta);

            }, i * 250);
        });
    }
}
