using ArchidonaGil.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchidonaGil.Services
{
    public class CategoriaRepositorioDB
    {
        public ExamenDbContext Context { get; set; }
        public CategoriaRepositorioDB(ExamenDbContext context)
        {
            Context = context;
        }

        public List<Categorias> GetCategorias()
        {
            return Context.Categorias.ToList();
        }
        
    }
}
