using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Models
{
    public class MvcStartAppContext : DbContext
    {
        public MvcStartAppContext(DbContextOptions<MvcStartAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
