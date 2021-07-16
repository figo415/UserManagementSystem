using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    interface IPurchasable
    {
		/// <summary>
		/// 购买来源
		/// </summary>
		public Link PurchaseFrom { get; set; }

		/// <summary>
		/// 购买价格
		/// </summary>
		public Price Price { get; set; }

		/// <summary>
		/// 购买日期：yyyy-MM-dd
		/// </summary>
		public DateTime? PurchaseDate { get; set; }

		/// <summary>
		/// 供应商：ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen
		/// </summary>
		public string Supplier { get; set; }
	}
}
