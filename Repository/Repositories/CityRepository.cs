using Core.DataAccess.EntityFramework;
using Repository.Dtos;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class CityRepository : BaseRepository<City, Proje1Context>, ICityRepository
	{
		public IList<CityListDto> GetCityList()
		{
			using (var context = new Proje1Context())// yazdığımız kod baserepositoryde yazdığımız kod dur ordakigeneric halidir 
			{
				var q = context.Citys.Where(i => i.IsActive).Select(city => new CityListDto()//sen burda citys içinden verileri çektin cityListdto içine aktardın buda viewde gelir eğer burda çekmezsen veriler viewe gelmez 
				{
					CreatedAt= city.CreatedAt,//bunu da baseentitydekini basedto içine atadık 
					CityPostCode=city.CityPostCode,
					CityPlate=city.CityPlate,
					CityName=city.CityName,//veritabanındaki citys tablosundan citynameyi dto daki cityname atadık 
					CreatedUserName= city.Users.Name+" "+city.Users.Surname, //biz burda city entities içine girerek ilişkideki users entitysine ulaştık ve burdan bunu CityListDto içine atadık 

				});
				return q.ToList();
			}
		}
	}
}
