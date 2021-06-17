using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 质量
	/// </summary>
	[Owned]
	public class Quality:IValueObject
	{

		/// <summary>
		/// 单位：ng,μg,mg,g,kg
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}