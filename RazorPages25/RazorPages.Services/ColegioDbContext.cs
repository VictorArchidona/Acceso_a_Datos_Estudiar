using Microsoft.EntityFrameworkCore;
using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class ColegioDbContext : DbContext
    {
        public ColegioDbContext(DbContextOptions<ColegioDbContext> options): base(options)
        {

        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
    }
}
