using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Repository.Entities
{
	public class BaseEntity:IEntity//buda core de tanımladığımız generic IEntity
	{
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public int? CreatedBy { get; set; }
		public int? UpdatedBy { get; set; }
		public int? DeletedBy { get; set; }
		public virtual User Users { get; set; }//bu city tablosu çoklu ,kullanıcı tablosu tekli anlamına geliyor
											   //base entity de olduğu için hangileri kaltım almışsa onlara gider
											   //her tabloyu bir kulanıcı oluşturu bir kullanıcı birden fazla tabloyu oluşturabilir
		public int RowOrder { get; set; }

	}
}
