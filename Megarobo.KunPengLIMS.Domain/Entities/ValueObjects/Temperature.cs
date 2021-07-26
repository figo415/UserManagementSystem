using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �¶�
	/// </summary>
	[Owned]
	public class Temperature : IValueObject
	{

		/// <summary>
		/// ��λ��C,F
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// ֵ��-20~50
		/// </summary>
		public float Value { get; set; }
	}
}