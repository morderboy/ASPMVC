using ASPMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASPMVC.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
			Database.EnsureCreated();
		}
		public DbSet<WeatherModel> Weather { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=database/weather.db");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WeatherModel>()
				.ToTable(b => b.HasCheckConstraint("contraint_type", "Type in ('F', 'C')"))
				.Property(b => b.Type).HasMaxLength(1);
		}
	}
}
