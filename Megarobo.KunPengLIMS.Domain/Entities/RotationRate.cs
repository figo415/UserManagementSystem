using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ת��
	/// </summary>
	//[ComplexType]
	[Owned]
	public class RotationRate:IValueObject
	{
		/// <summary>
		/// ��λ:rpm,g
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}