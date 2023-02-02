using Microsoft.AspNetCore.Mvc;
using Repository.Dtos;
using Repository.Entities;
using Services.Interfaces;

namespace Proje1.Controllers
{
	public class CityController : Controller
	{
		private ICityService _icityService;

		public CityController(ICityService icityService)
		{
			_icityService = icityService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ListCity()
		{
			var model = _icityService.GetList2().Data;
			return View(model);
		}
		[HttpGet]
		public IActionResult EditCity(int id)
		{
			var model =_icityService.GetById(id).Data;//burda getbydıd de successdata kullandın için vermek zorndasın datayı 
			return View(model);
		}
		[HttpPost]
		public IActionResult EditCity(CityEditDto model)
		{
			if (model.Citys.Id == 0)
			{
			
				ViewBag.Mode = "Ekle";//bunu ekleme olduğunda gelsin bu yazı güncelleme içinde gecerli 
				_icityService.Add(model.Citys);
			}
			else
			{
				ViewBag.Mode = "Güncelle";//bunları view kısmında da çağırman lazım ki gelsin
				_icityService.Update(model.Citys);
			}
			return RedirectToAction("ListCity");
		}
	}
}
