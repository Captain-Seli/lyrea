using Microsoft.EntityFrameworkCore;

namespace Lyrean_Companion_App
{
	public class LyreanCompanionDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LyreanCompanionDb;Trusted_Connection=True;");
		}
	}
}