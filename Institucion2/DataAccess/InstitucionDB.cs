using Institucion2.Model;
using System.Data.Entity;

namespace Institucion2.DataAccess
{
    public class InstitucionDB: DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
