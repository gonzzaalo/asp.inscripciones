namespace Inscripciones.Models
{
    public class Carrera
    {
        public int id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
