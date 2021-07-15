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
	/// ���
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Cubage:IValueObject
	{

		/// <summary>
		/// ��λ����L,mL
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// ֵ
		/// </summary>
		public float Value { get; set; }

        public override string ToString()
        {
			return Value.ToString() + Unit;
        }
    }
}