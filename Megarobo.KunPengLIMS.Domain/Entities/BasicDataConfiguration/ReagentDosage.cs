//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// 试剂用量
//	/// </summary>
//	/// 与Reagent多对一
//	/// 与Solution多对多
//	public class ReagentDosage:Entity
//	{
//		/// <summary>
//		/// 体积
//		/// </summary>
//		public Cubage Cubage { get; set; }

//		/// <summary>
//		/// 质量
//		/// </summary>
//		public Quality Quality { get; set; }

//		/// <summary>
//		/// 外键到试剂
//		/// </summary>
//		public Guid ReagentId { get; set; }

//		[ForeignKey("ReagentId")]
//		public Reagent Reagent { get; set; }

//		public virtual ICollection<SolutionReagentDosage> Solutions { get; set; }
//	}
//}