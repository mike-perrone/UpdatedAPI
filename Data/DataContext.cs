using NamingThingsIsHard.Models;
using Microsoft.EntityFrameworkCore;

namespace NamingThingsIsHard.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}