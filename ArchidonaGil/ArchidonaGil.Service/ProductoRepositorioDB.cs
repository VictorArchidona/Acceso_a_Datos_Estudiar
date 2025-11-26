using ArchidonaGil.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace ArchidonaGil.Services
{
    public class ProductoRepositorioDB
    {
        public ExamenDbContext Context { get; set; }
        
        public ProductoRepositorioDB(ExamenDbContext context)
        {
            Context = context;
        }

        public List<Productos> GetProductosPorCategoria(int categoriaId)
        {
            return Context.Productos.Where(p => p.CategoriaId == categoriaId).ToList();
        }

        public List<Productos> GetProductosCategoria(int categoriaId)
        {
            return Context.Productos
                .Where(p => p.CategoriaId == categoriaId)
                .ToList();
        }

        public decimal GetTotalVentasPorCategoria(int categoriaId)
        {
            return Context.Productos
                .Where(p => p.CategoriaId == categoriaId)
                .Sum(p => p.Precio);
        }
    }
}
