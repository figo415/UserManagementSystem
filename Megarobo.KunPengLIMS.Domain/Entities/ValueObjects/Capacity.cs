using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// µÁ»›
	/// </summary>
	[Owned]
	public class Capacity:IValueObject
	{

		/// <summary>
		/// µ•Œª£∫F,¶ÃF,nF,pF
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }

	}
}