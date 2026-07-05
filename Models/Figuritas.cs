namespace TP04Prog.Models
{
    public class Figuritas
    {
        public int ID{get; set; }
        public int Numero {get; set;}
        public int idJugador { get; set; }

        public Jugadores Jugador { get; set; }
        public bool Pegada { get; set; }
        public int Cantidad { get; set; }
    }
}