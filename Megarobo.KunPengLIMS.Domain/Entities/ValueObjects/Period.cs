using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ʱ������
	/// </summary>
	[Owned]
	public class Period:IValueObject
	{
		public int End { get; set; }

		public int Start { get; set; }

		/// <summary>
		/// ��λ����,ʱ,��,��
		/// </summary>
		public string Unit { get; set; }
	}
}