using Microsoft.EntityFrameworkCore;
using MyWebApp.API.Models;

namespace MyWebApp.API.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=###; user id=###; password=###;Database=MyAppSampDb; Integrated Security=False");
        }

        public DbSet<User> Users { get; set; }
    }
}