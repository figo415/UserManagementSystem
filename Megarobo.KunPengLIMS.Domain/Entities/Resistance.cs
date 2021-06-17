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
	public class Resistance:IValueObject
	{

		/// <summary>
		/// ��λ��ohm,��
		/// </summary>
		public string Unit
        {
            get; set;

		}

		public float Value { get; set; }
	}
}