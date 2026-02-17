using System.ComponentModel.DataAnnotations.Schema;

namespace VictorAPI.Models
{
    public class autores
    {
        public int id { get; set; }
        public string nom_autor { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        [NotMapped]
        public DateOnly f_nac { get; set; }
        [NotMapped]
        public DateOnly f_def { get; set; }
        public int paisId { get; set; }
        public string foto { get; set; }
        public string localidad { get; set; }
        public string biografia { get; set; }

        public List<autor_premio> autorPremios { get; set; }
        public List<autor_libro> libroAutores { get; set; }
    }
}
