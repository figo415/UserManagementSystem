using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// Ũ��
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Thickness:IValueObject
	{

		/// <summary>
		/// ��λ��%,mg/ml
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }

        public override string ToString()
        {
			return Value.ToString() + Unit;
        }
    }
}