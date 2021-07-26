using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 时间区间
	/// </summary>
	[Owned]
	public class Period:IValueObject
	{
		public int End { get; set; }

		public int Start { get; set; }

		/// <summary>
		/// 单位：天,时,分,秒
		/// </summary>
		public string Unit { get; set; }
	}
}