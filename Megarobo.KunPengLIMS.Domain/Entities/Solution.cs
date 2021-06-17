using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
		public List<SolutionReagentDosage> ReagentDosages { get; set; }

		/// <summary>
		/// ���������б�
		/// </summary>
		public List<SolutionSampleDosage> SampleDosages { get; set; }

		/// <summary>
		/// Ƕ��ֵ�������
		/// </summary>
		public Cubage Total { get; set; }

		public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; }
	}
}