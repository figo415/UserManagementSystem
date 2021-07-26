using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ת��
	/// </summary>
	[Owned]
	public class RotationRate:IValueObject
	{
		/// <summary>
		/// ��λ:rpm,g
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}