//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// �Լ�����
//	/// </summary>
//	/// ��Reagent���һ
//	/// ��Solution��Զ�
//	public class ReagentDosage:Entity
//	{
//		/// <summary>
//		/// ���
//		/// </summary>
//		public Cubage Cubage { get; set; }

//		/// <summary>
//		/// ����
//		/// </summary>
//		public Quality Quality { get; set; }

//		/// <summary>
//		/// ������Լ�
//		/// </summary>
//		public Guid ReagentId { get; set; }

//		[ForeignKey("ReagentId")]
//		public Reagent Reagent { get; set; }

//		public virtual ICollection<SolutionReagentDosage> Solutions { get; set; }
//	}
//}