using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// µÁ—π
	/// </summary>
	[Owned]
	public class Voltage : IValueObject
	{

		/// <summary>
		/// µ•Œª£∫V,mV
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}