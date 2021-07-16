using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ��Һ��ϵ
	/// </summary>
	/// ��ProtocolStepһ�Զ�
	/// ��ReagentDosage��Զ�
	/// ��SampleDosage��Զ�
	public class Solution:Entity
	{
		/// <summary>
		/// �Լ������б�
		/// </summary>
		//public List<SolutionReagentDosage> ReagentDosages { get; set; }
		public virtual ICollection<ReagentUsage> ReagentUsages { get; set; }

		/// <summary>
		/// ���������б�
		/// </summary>
		//public List<SolutionSampleDosage> SampleDosages { get; set; }
		public List<SampleDosage> SampleDosages { get; set; }

		/// <summary>
		/// ���
		/// </summary>
		public Cubage Total { get; set; }

		//public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; }
		public Guid ProtocolStepId { get; set; }

		[ForeignKey("ProtocolStepId")]
		public ProtocolStep ProtocolStep { get; set; }
	}
}