using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Context
{
	public class Proje1Context:DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<City> Citys { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				//IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
				//optionsBuilder.UseSqlServer(configuration.GetConnectionString("ArvesoftConnectionStringProje1"));

				IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();//ConfigurationBuilder,AddJsonFile bu ikisi için iki ayrı kütüphane gerekkli
				optionsBuilder.UseSqlServer(configuration.GetConnectionString("ArvesoftConnectionStringProje1"));
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>(entity =>
			{
				entity.Property(x => x.CityName).HasMaxLength(200);
				entity.Property(x => x.CityPlate).IsRequired();
				entity.HasOne(x => x.Users).WithMany(x => x.Citys).HasForeignKey(x => x.CreatedBy);//tekli olan ilişkide forein key verilir
			});

			
		}
	}
}
