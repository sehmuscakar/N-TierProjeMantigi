using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class City:BaseEntity
	{

		public string CityName { get; set; }//ilin ismi
		public int CityPostCode { get; set; }//ildeki posta kodu
		public int CityPlate { get; set; }//ilin plakası

		//public virtual ICollection<District> Districts { get; set; }

	}
}
