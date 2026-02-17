using Microsoft.EntityFrameworkCore;
using VictorAPI.Models;
using VictorMVCv1.Models;

namespace VictorAPI.Data
{
    public class BibliotecaRepositorio
    {
        public readonly Contexto Contexto;
        public BibliotecaRepositorio(Contexto contexto)
        {
            Contexto = contexto;           
        }

        public async Task<List<autores>> obtenerAutoresAsync()
        {
            return await Contexto.autores.ToListAsync();
        }
    }
}
