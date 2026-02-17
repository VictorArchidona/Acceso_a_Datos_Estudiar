using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace VictorMVCv1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Pais> paises { get; set; }
        public DbSet<premios> premios { get; set; }
        public DbSet<autores> autores { get; set; }
        public DbSet<libro> libros { get; set; }
        public DbSet<autor_libro> autor_libro { get; set; }
        public DbSet<autor_premio> autor_premios { get; set; }
        public DbSet<libro_premio> libro_premios { get; set; }

    }
}
