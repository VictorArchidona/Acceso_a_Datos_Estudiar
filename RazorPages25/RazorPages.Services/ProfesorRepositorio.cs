using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class ProfesorRepositorio
    {
        public ColegioDbContext Context { get; }
        public ProfesorRepositorio(ColegioDbContext context)
        {
            Context = context;
        }
        public IEnumerable<Profesor> GetAllProfesores()
        {
            return Context.Profesores;
        }

    }
}
