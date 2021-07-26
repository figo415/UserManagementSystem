using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ��ѹ
	/// </summary>
	[Owned]
	public class Voltage : IValueObject
	{

		/// <summary>
		/// ��λ��V,mV
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}