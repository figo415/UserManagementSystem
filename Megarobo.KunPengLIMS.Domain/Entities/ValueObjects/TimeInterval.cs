using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 时间间隔
	/// </summary>
	[Owned]
	public class TimeInterval:IValueObject
	{

		/// <summary>
		/// 单位：天,时,分,秒
		/// </summary>
		public string Unit { get; set; }

		public int Value { get; set; }
	}
}