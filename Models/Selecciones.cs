namespace TP04Prog.Models
{
    public class Selecciones
    {

        public int ID{get; set; }
        public string Nombre {get; set;}
        public char Grupo { get; set; }
        public List<Figuritas> Figuritas { get; set; }

    }
}