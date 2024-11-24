using Microsoft.EntityFrameworkCore;
using MyVideostore.Models;

namespace MyVideostore.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Video> Video { get; set; }
        public required DbSet<Genre> Genre { get; set; }
      //  public required DbSet<Video> VideoList { get; set; }
    }
}
