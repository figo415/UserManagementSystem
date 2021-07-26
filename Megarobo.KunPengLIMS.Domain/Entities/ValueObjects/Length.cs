using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ����
	/// </summary>
	[Owned]
	public class Length:IValueObject
	{

		/// <summary>
		/// ��λ��km,m,cm,mm,��m,nm
		/// </summary>
		public string Unit { get; set; }

		public float Value { get; set; }
	}
}