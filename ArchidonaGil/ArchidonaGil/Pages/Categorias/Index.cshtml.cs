using ArchidonaGil.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CategoriaModel = ArchidonaGil.Modelos.Categorias;

namespace ArchidonaGil.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly CategoriaRepositorioDB categoriaRepositorio;
        private readonly ProductoRepositorioDB productoRepositorio;

        public List<CategoriaModel> Categorias { get; set; }

        public IndexModel(
            CategoriaRepositorioDB categoriaRepositorioDB,
            ProductoRepositorioDB productoRepositorioDB)
        {
            categoriaRepositorio = categoriaRepositorioDB;
            productoRepositorio = productoRepositorioDB;
        }

        public void OnGet()
        {
            
            Categorias = categoriaRepositorio.GetCategorias();
        }

        public IActionResult OnGetProductosCategoria(int categoriaId)
        {
            return ViewComponent("ProductoCategoria", new { categoriaId = categoriaId });
        }

        public IActionResult OnGetTotalVentasCategoria(int categoriaId)
        {
            return ViewComponent("TotalVentasCategoria", new { categoriaId = categoriaId });
        }
    }
}
