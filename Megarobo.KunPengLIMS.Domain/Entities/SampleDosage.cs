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
		/// ��������
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///���
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		///����
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// ��ϸ�������������Ч�����������������Ч
		/// </summary>
		public bool IsCell { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// ���������
		/// </summary>
		public Guid SampleId;

		[ForeignKey("SampleId")]
		public Sample Sample { get; set; }

        /// <summary>
        /// �����Soluation
        /// </summary>
        public Guid SolutionId { get; set; }

        [ForeignKey("SolutionId")]
        public Solution Solution { get; set; }

        //public virtual ICollection<SolutionSampleDosage> Solutions { get; set; }
    }
}