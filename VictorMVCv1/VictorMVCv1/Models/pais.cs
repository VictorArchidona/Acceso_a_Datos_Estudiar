using System.ComponentModel.DataAnnotations.Schema;

namespace VictorMVCv1.Models
{
    public class Pais
    {
        public int id { get; set; }
        public string nom_pais { get; set; }
        public string bandera { get; set; }
        public List<premios> premios { get; set; }
        
        [NotMapped]
        public List<int> premiosId { get; set; }
    }
}
