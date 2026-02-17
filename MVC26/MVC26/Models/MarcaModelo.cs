namespace MVC26.Models
{
    public class MarcaModelo
    {
        public int ID { get; set; }
        public string Nom_Marca { get; set; }
        public MarcaModelo Marca { get; set; }
        public int MarcaID { get; set; }
    }
}
