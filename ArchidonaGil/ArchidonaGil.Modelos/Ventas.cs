using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchidonaGil.Modelos
{
    public class Ventas
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaVenta { get; set; }
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una cantidad.")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un nombre de cliente.")]
        public string Cliente { get; set; }

    }
}
