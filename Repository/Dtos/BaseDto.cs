using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
	public class BaseDto
	{
		public int Id { get; set; }
		public DateTime? CreatedAt { get; set; }//oluşturulma zamanı 
		public string CreatedUserName { get; set; }
	}
}
