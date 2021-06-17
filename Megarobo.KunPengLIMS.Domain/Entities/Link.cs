using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// Á´½Ó
	/// </summary>
	//[ComplexType]
	[Owned]
	public class Link:IValueObject
	{
		public string Name{ get; set; }

		public string Url { get; set; }
	}
}