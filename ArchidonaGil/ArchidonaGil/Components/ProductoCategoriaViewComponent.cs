using ArchidonaGil.Modelos;
using ArchidonaGil.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArchidonaGil.Components
{
    public class ProductoCategoriaViewComponent : ViewComponent
    {
        public ProductoRepositorioDB productoRepositorio { get; }

        public CategoriaRepositorioDB categoriaRepositorio { get; set; }

        public ProductoCategoriaViewComponent(ProductoRepositorioDB productoRepositorioDB)
        {
            productoRepositorio = productoRepositorioDB;
        }

        public IViewComponentResult Invoke(int categoriaId)
        {
            var productos = productoRepositorio.GetProductosPorCategoria(categoriaId);
            return View(productos);
        }
    }
}
