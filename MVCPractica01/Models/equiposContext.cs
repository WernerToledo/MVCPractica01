using Microsoft.EntityFrameworkCore;
namespace MVCPractica01.Models
{
    public class equiposContext : DbContext
    {
        public equiposContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<equipos> equipos {get; set;}
    }
}
