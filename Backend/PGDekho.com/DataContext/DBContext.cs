using Microsoft.EntityFrameworkCore;
using PGDekho.com.Models;

namespace PGDekho.com.DataContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Register>Registers { get; set; }
        public DbSet<PropertyDetails> PropertyDetails { get; set; }
    }
}
