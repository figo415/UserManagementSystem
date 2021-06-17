using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �¶�
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Temperature : IValueObject
	{

		/// <summary>
		/// ��λ��C,F
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// ֵ��-20~50
		/// </summary>
		public float Value { get; set; }
	}
}