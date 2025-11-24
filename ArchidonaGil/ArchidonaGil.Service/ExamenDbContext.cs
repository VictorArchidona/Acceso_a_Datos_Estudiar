using Microsoft.EntityFrameworkCore;

namespace ArchidonaGil.Services
{
    public class ExamenDbContext : DbContext
    {
        public ExamenDbContext(DbContextOptions<ExamenDbContext> options) : base(options)
        {
        }

    }
}
