using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
	public class CityListDto:BaseDto//listeleme yapacağımız 
	{
    	public string CityName { get; set; }//ilin ismi
		public int CityPostCode { get; set; }//ildeki posta kodu
		public int CityPlate { get; set; }//ilin plakası
	}
}
