using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 长度
	/// </summary>
	[ComplexType]
	public class Length:IValueObject
	{

		/// <summary>
		/// 单位：km,m,cm,mm,μm,nm
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}