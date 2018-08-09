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
            optionsBuilder.UseSqlServer(@"Server=myserver0001.database.windows.net; user id=myappserver; password=Pr0xxxy@!#***;Database=MyAppSampDb; Integrated Security=False");
        }

        public DbSet<User> Users { get; set; }
    }
}