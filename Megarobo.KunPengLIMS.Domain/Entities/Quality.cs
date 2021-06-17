using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ����
	/// </summary>
	[Owned]
	public class Quality:IValueObject
	{

		/// <summary>
		/// ��λ��ng,��g,mg,g,kg
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}