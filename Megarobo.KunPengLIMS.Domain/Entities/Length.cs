using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ����
	/// </summary>
	[ComplexType]
	public class Length:IValueObject
	{

		/// <summary>
		/// ��λ��km,m,cm,mm,��m,nm
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}