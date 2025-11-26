using ArchidonaGil.Services;
using CategoriaModel = ArchidonaGil.Modelos.Categorias;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ArchidonaGil.Modelos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArchidonaGil.Pages.Ventas
{
    public class IndexModel : PageModel
    {
        private readonly CategoriaRepositorioDB categoriaRepositorio;
        private readonly ProductoRepositorioDB productoRepositorio;
        private readonly VentasRepositorioDB ventasRepositorio;

        public List<CategoriaModel> Categorias { get; set; }
        public List<Productos> Productos { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Debe seleccionar una categoría.")]
        public int? CategoriaId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Debe seleccionar un producto.")]
        public int? ProductoId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Es obligatorio introducir una cantidad.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int? Cantidad { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Es obligatorio introducir un nombre de cliente.")]
        public string Cliente { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Es obligatorio introducir una fecha.")]
        public DateTime? FechaVenta { get; set; }

        public IndexModel(
            CategoriaRepositorioDB categoriaRepositorio,
            ProductoRepositorioDB productoRepositorio,
            VentasRepositorioDB ventasRepositorio)
        {
            this.categoriaRepositorio = categoriaRepositorio;
            this.productoRepositorio = productoRepositorio;
            this.ventasRepositorio = ventasRepositorio;
        }

        public void OnGet()
        {
            Categorias = categoriaRepositorio.GetCategorias();

            
            if (!FechaVenta.HasValue)
            {
                FechaVenta = DateTime.Today;
            }

            
            if (CategoriaId.HasValue && CategoriaId.Value > 0)
            {
                Productos = productoRepositorio.GetProductosCategoria(CategoriaId.Value);
            }
            else
            {
                Productos = new List<Productos>();
            }
        }

        public IActionResult OnPost()
        {
            
            Categorias = categoriaRepositorio.GetCategorias();

            if (CategoriaId.HasValue && CategoriaId.Value > 0)
            {
                Productos = productoRepositorio.GetProductosCategoria(CategoriaId.Value);
            }
            else
            {
                Productos = new List<Productos>();
            }

            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            var venta = new ArchidonaGil.Modelos.Ventas
            {
                ProductoId = ProductoId.Value,
                Cantidad = Cantidad.Value,
                Cliente = Cliente,
                FechaVenta = FechaVenta.Value
            };

            // Insertar en la base de datos
            ventasRepositorio.InsertarVenta(venta);

            TempData["Mensaje"] = "Venta insertada correctamente.";

            // Redirigir para limpiar el formulario
            return RedirectToPage();
        }
    }
}