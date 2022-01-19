using Microsoft.EntityFrameworkCore;
using BookBulky.Models;
namespace BookBulky.Data
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
       

    }
}

