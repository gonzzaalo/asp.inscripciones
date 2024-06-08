namespace Inscripciones.Models
{
    public class AnioCarrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
    }
}
