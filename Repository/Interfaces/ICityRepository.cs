using Core.DataAccess;
using Repository.Dtos;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
	public interface ICityRepository:IEntityRepository<City>
	{
		IList<CityListDto> GetCityList();
	}
}
