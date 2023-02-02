
using Core.Utilities;
using Repository.Dtos;
using Repository.Entities;

namespace Services.Interfaces
{
	public interface ICityService
	{
		IResult Add(City entitiy);

		IDataResult<City> GetById(int ıd);//buda veriyi getirmek için get için yani
		IDataResult<List<City>> GetList();//bunlar generic olarak tanımladıklarımızı çağırıyoruz,çağıracaz repsitoryde

		IResult Update(City entitiy);//buda generic 

		IDataResult<List<CityListDto>> GetList2();


	}
}
