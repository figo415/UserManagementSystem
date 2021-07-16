using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class ReagentUsage:Entity
    {
		/// <summary>
		/// 试剂名称
		/// </summary>
        public string Name { get; set; }

		/// <summary>
		/// 体积
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// 质量
		/// </summary>
		public Quality Quality { get; set; }

		public Guid SolutionId { get; set; }

		[ForeignKey("SolutionId")]
		public Solution Solution { get; set; }
	}
}
