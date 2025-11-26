using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchidonaGil.Modelos
{
    public class Productos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un precio.")]
        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }
    }
}
