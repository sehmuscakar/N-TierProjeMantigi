using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using Services.Services;

namespace Proje1.Extensions
{
	public static class ServiceExtension
	{
		public static void MyConfigureServices(this IServiceCollection services)//bunu program.cs de tanımlaman lazım myconfigiration diye 
		{
			services.AddScoped<ICityService, CityService>();//yani bunun birisini tanımlandığında ınterface olsun diğerini algıla 
			services.AddScoped<ICityRepository, CityRepository>();


			//services.AddScoped<IDistrictService, DistrictService>();
			//services.AddScoped<IDistrictRepository, DistrictRepository>();
		}
	}
}
