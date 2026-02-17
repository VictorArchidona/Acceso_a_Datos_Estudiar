namespace VictorMVCv1.Models
{
    public class libro_premio
    {
        public int id { get; set; }
        public libro libro { get; set; }
        public int libroId { get; set; }
        public premios premio { get; set; }
        public int premioId { get; set; }   
    }
}
