using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class User:IEntity
	{
		public DateTime? LastLogin { get; set; }
		public string Name { get; set; }//soru işareti olmayan zorunlu alan değil 
		public string Surname { get; set; }
		public string Pasworrd { get; set; }

	//	#region BaseEntity
		public int Id { get; set; }
		//public bool IsActive { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public int? CreatedBy { get; set; }
		public int? UpdatedBy { get; set; }
		public int? DeletedBy { get; set; }
		public bool IsActive { get; set; }
	//	#endregion
		public int RowOrder { get; set; }

		public virtual ICollection<City> Citys { get; set; }//bu city tablosu çoklu ,kullanıcı tablosu tekli anlamına geliyor

	//	public virtual ICollection<District> Districts { get; set; } 


	}
}
