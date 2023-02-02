using Core.Utilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Dtos;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
	public class CityService : ICityService
	{
		ICityRepository _icityRepository;//burda repositoryden buraya çağırıyoruz 

		public CityService(ICityRepository icityRepository)
		{
			_icityRepository = icityRepository;
		}

		public IResult Add(City entitiy) //burda da post ta 
		{
			entitiy.CreatedAt = DateTime.Now;//burda eklerken hangi saate ekleme olmuşsa onuda ekleyecek 
			entitiy.CreatedBy = 5;							
			entitiy.IsActive = true;
			_icityRepository.Add(entitiy);//bu add metodu generic olarak yazılmış
			return new SuccessResult();
		}

		public IDataResult<City> GetById(int id)//bunu add te veriyi getirmek ve view açılsın diye yapıyoruz
        {
			return new SuccessDataResult<City>(_icityRepository.Get(p => p.Id == id));//bu get metodu generic olarak yazılan get metodu 
		}

		public IDataResult<List<City>> GetList()
		{
			return new SuccessDataResult<List<City>>(_icityRepository.GetActiveList().ToList());
		}

		public IDataResult<List<CityListDto>> GetList2()//bu generic değil biz yazdık bunu 
		{
		return new SuccessDataResult<List<CityListDto>>(_icityRepository.GetCityList().ToList());
		}

		public IResult Update(City entitiy)
		{
			_icityRepository.Update(entitiy);//bu gelen update metodu genericteki gelendir IEntityRepositorydeki olan 
			return new SuccessResult("Başarılı bir şekilde güncelendi");//eğer data olsaydı onu vermeliydin controller kısmında  
		}
	}
}
