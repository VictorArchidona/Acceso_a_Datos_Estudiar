using System.ComponentModel.DataAnnotations.Schema;

namespace VictorMVCv1.Models
{
    [Table("autor_libro")]
    public class autor_libro
    {
        public int id { get; set; }
        public autores autor { get; set; }
        public int autorId { get; set; }
        public libro libro { get; set; }
        public int libroId { get; set; }
    }
}