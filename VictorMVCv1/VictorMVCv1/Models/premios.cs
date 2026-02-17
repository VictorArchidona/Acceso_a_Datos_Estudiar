namespace VictorMVCv1.Models
{
    public class premios
    {
        public int id { get; set; }
        public string nom_premio { get; set; }
        public Pais pais { get; set; }
        public int paisId { get; set; }
        public string tipo { get; set; }

        public List<autor_premio> autorPremios { get; set; }
    }
}
