using Microsoft.EntityFrameworkCore;
using MyFavMusique.Models;

namespace MyFavMusique.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Music> Music { get; set; } 
        public DbSet<Genre> Genres { get; set; }    

    }
}
