using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ��������
	/// </summary>
	/// ��Sample���һ
	/// ��Solution��Զ�
	public class SampleDosage:Entity
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
		/// ����
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// ���������
		/// </summary>
		public Guid SampleID;

		[ForeignKey("SampleID")]
		public Sample Sample { get; set; }

		/// <summary>
		/// �����Soluation
		/// </summary>
		//public Guid SolutionID { get; set; }

		//[ForeignKey("SolutionID")]
		//public Solution Solution { get; set; }

		public virtual ICollection<SolutionSampleDosage> Solutions { get; set; }
	}
}