using Microsoft.EntityFrameworkCore;
using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class AsignaturaRepositorio
    { 
        public ColegioDbContext Context { get; }
        public AsignaturaRepositorio(ColegioDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Asignatura> GetAllAsignaturas()
        {
            return Context.Asignaturas;
        }
        public Asignatura GetAsignatura(int ID)
        {
            return Context.Asignaturas.Find(ID);
        }
        public IEnumerable<Asignatura> GetAsignaturasCurso(Curso codigo)
        {
            return Context.Asignaturas.Where(a => a.cursoID == codigo);
        }
        public IEnumerable<Asignatura> GetAsignaturasProfesor(int profeId)
        {
            return Context.Asignaturas.Where(a => a.profeID == profeId);
        }
    }
}
