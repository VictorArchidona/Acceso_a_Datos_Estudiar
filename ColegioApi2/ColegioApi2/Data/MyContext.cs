using ColegioApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace ColegioApi2.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
