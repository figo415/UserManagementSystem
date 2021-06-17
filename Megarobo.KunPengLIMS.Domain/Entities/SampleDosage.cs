using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 样本用量
	/// </summary>
	/// 与Sample多对一
	/// 与Solution多对多
	public class SampleDosage:Entity
	{
		/// <summary>
		/// 嵌入值对象：体积
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// 嵌入值对象：质量
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// 外键到样本
		/// </summary>
		public Guid SampleID;

		[ForeignKey("SampleID")]
		public Sample Sample { get; set; }

		/// <summary>
		/// 外键到Soluation
		/// </summary>
		//public Guid SolutionID { get; set; }

		//[ForeignKey("SolutionID")]
		//public Solution Solution { get; set; }

		public virtual ICollection<SolutionSampleDosage> Solutions { get; set; }
	}
}