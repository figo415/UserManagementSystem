using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 体积
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Cubage:IValueObject
	{

		/// <summary>
		/// 单位：μL,mL
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// 值
		/// </summary>
		public float Value { get; set; }

        public override string ToString()
        {
			return Value.ToString() + Unit;
        }
    }
}