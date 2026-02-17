using System.ComponentModel.DataAnnotations.Schema;

namespace VictorAPI.Models
{
    public class autor_premio
    {
        public int id { get; set; }
        public int autorId { get; set; }
        public int premioId { get; set; }
        [NotMapped]
        public DateOnly anio { get; set; }
    }
}
