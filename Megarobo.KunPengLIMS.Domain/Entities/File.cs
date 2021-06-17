using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// нд╪Ч
	/// </summary>
	//[ComplexType]
	[Owned]
	public class File:IValueObject
	{
		public string Name { get; set; }
		public string Url { get; set; }
	}
}

