using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 转速
	/// </summary>
	[Owned]
	public class RotationRate:IValueObject
	{
		/// <summary>
		/// 单位:rpm,g
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}