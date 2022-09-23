using Qlegis.Models;
using Microsoft.EntityFrameworkCore;

namespace Qlegis.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) 
            : base(options)
        { }
        public DbSet<UserModel> User { get; set; }
    }
}
