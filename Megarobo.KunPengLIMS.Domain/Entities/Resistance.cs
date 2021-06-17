using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// µç×è
	/// </summary>
	[ComplexType]
	public class Resistance:IValueObject
	{

		/// <summary>
		/// µ¥Î»£ºohm,¦¸
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}