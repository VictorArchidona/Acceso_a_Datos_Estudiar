using ArchidonaGil.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArchidonaGil.Components
{
    public class TotalVentasCategoriaViewComponent : ViewComponent
    {
        public ProductoRepositorioDB productoRepositorio { get; }
        public CategoriaRepositorioDB categoriaRepositorio { get; }

        public TotalVentasCategoriaViewComponent(
            ProductoRepositorioDB productoRepositorioDB,
            CategoriaRepositorioDB categoriaRepositorioDB)
        {
            productoRepositorio = productoRepositorioDB;
            categoriaRepositorio = categoriaRepositorioDB;
        }

        public IViewComponentResult Invoke(int categoriaId)
        {
            var categoria = categoriaRepositorio.GetCategorias()
                .FirstOrDefault(c => c.Id == categoriaId);
            
            var totalVentas = productoRepositorio.GetTotalVentasPorCategoria(categoriaId);
            
            ViewData["CategoriaNombre"] = categoria?.Nombre ?? "";
            ViewData["TotalVentas"] = totalVentas;
            
            return View();
        }
    }
}
