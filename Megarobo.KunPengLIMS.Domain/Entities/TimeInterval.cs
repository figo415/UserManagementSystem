using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ʱ����
	/// </summary>
	//[ComplexType]
	[Owned]
	public class TimeInterval:IValueObject
	{

		/// <summary>
		/// ��λ����,ʱ,��,��
		/// </summary>
		public string Unit { get; set; }

		public int Value { get; set; }
	}
}