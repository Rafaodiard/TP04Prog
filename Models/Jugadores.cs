namespace TP04Prog.Models
{
    public class Jugadores
    {
        public int ID{get; set; }
        public string Nombre {get; set;}
        public int Ncamiseta { get; set; }
        public int idSeleccion { get; set; }
        public string Imagen { get; set; }

        public Selecciones Seleccion {get; set;}
    }
}