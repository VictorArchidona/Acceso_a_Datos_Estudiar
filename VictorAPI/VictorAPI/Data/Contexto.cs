using Microsoft.EntityFrameworkCore;
using VictorAPI.Models.Autor;

namespace VictorAPI.Data
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            
        }

        public DbSet<Autor> autor { get; set; }
    }
}
