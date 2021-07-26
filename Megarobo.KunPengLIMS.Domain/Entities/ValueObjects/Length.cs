using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 长度
	/// </summary>
	[Owned]
	public class Length:IValueObject
	{

		/// <summary>
		/// 单位：km,m,cm,mm,μm,nm
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}