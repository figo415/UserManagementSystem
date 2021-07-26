using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 温度
	/// </summary>
	[Owned]
	public class Temperature : IValueObject
	{

		/// <summary>
		/// 单位：C,F
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// 值：-20~50
		/// </summary>
		public float Value { get; set; }
	}
}