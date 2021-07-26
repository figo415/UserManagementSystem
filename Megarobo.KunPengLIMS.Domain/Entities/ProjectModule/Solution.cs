using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 溶液体系
	/// </summary>
	/// 与ProtocolStep一对多
	/// 与ReagentDosage多对多
	/// 与SampleDosage多对多
	public class Solution:Entity
	{
		/// <summary>
		/// 试剂用量列表
		/// </summary>
		//public List<SolutionReagentDosage> ReagentDosages { get; set; }
		public virtual ICollection<ReagentUsage> ReagentUsages { get; set; }

		/// <summary>
		/// 样本用量列表
		/// </summary>
		//public List<SolutionSampleDosage> SampleDosages { get; set; }
		public List<SampleDosage> SampleDosages { get; set; }

		/// <summary>
		/// 体积
		/// </summary>
		public Cubage Total { get; set; }

		//public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; }
		public Guid ProtocolStepId { get; set; }

		[ForeignKey("ProtocolStepId")]
		public ProtocolStep ProtocolStep { get; set; }
	}
}