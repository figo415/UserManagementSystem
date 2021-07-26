using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// Å¨¶È
	/// </summary>
	[Owned]
	public class Thickness:IValueObject
	{

		/// <summary>
		/// µ¥Î»£º%,mg/ml
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }

        public override string ToString()
        {
			return Value.ToString() + Unit;
        }
    }
}