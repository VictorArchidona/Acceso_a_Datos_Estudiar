using System.ComponentModel.DataAnnotations.Schema;

namespace VictorAPI.Models
{
    public class libro
    {
        public int id { get; set; }
        public string nom_libro { get; set; }
        public long ano { get; set; }
        public string portada { get; set; }
        public string nom_archivo { get; set; }
        public string pelicula { get; set; }
        public string comentario { get; set; }

        [Column("indice_serie")]
        public int indiceSerie { get; set; }

        [ForeignKey("serie")]
        public int? serieId { get; set; }
        public serie? serie { get; set; }

        public List<libro_premio> libroPremios { get; set; }
        public List<autor_libro> libroAutores { get; set; }
    }
}
