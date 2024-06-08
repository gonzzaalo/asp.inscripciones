using Microsoft.EntityFrameworkCore;

namespace Inscripciones.Models
{
    public class InscripcionesContext : DbContext
    {
        public InscripcionesContext(DbContextOptions<InscripcionesContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;      
            //               Database=InscripcionesContext;
            //               User Id = sa; Password = 123;
            //               MultipleActiveResultSets = True; 
            //               Encrypt=false ") ;
            string cadenaConexion ="Server=5.57.213.17;Database=smartsof_sofirey;User=smartsof_rey;Password=reysofi1234;";


            optionsBuilder.UseMySql(cadenaConexion,
            ServerVersion.AutoDetect(cadenaConexion));
        }

        public virtual DbSet<Alumno> alumnos { get; set; }
        public virtual DbSet<Carrera> carreras { get; set; }
        public virtual DbSet<Inscripcion> Inscripciones { get; set; }
        public virtual DbSet<AnioCarrera> AnioCarreras { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<DetalleInscripcion> DetalleInscripcions { get; set; }
    }
}
