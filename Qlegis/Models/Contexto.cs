using Microsoft.EntityFrameworkCore;

namespace Qlegis.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<UserModel> UserModel { get; set; }

    }
}
