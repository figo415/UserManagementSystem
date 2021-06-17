using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �Լ�����
	/// </summary>
	/// ��Reagent���һ
	/// ��Solution��Զ�
	public class ReagentDosage:Entity
	{
		/// <summary>
		/// Ƕ��ֵ�������
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// Ƕ��ֵ��������
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// ������Լ�
		/// </summary>
		public Guid ReagentID { get; set; }

		[ForeignKey("ReagentID")]
		public Reagent Reagent { get; set; }

		public virtual ICollection<SolutionReagentDosage> Solutions { get; set; }
	}
}