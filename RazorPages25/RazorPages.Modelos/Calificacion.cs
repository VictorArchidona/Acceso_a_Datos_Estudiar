using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Modelos
{
    public class Calificacion
    {
        public int ID { get; set; }
        [Required]
        public Convocatoria convocatoria { get; set; }
        public int asignaturaID { get; set; }
        public int alumnoID { get; set; }
        public int nota { get; set; }
    }
}
