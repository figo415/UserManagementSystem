using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �۸�
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Price:IValueObject
	{

		/// <summary>
		/// ��λ��Ԫ,$
		/// </summary>
		public string Unit
        {
            get; set;
		}

		public float Value { get; set; }
	}
}