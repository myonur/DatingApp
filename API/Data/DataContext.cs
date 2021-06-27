using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions optipns) : base(optipns)
        {
            
        }

        public DbSet<AppUser> Users {get; set;}

    }
}