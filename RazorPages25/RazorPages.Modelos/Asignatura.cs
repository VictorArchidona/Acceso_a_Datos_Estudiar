using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Modelos
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string nomAsignatura { get; set; }
        public int horas { get; set; }
        public string codAsignatura { get; set; }
        public Curso cursoID { get; set; }
        public int profeID { get; set; }
    }
}
