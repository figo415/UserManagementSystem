using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 连线
	/// </summary>
	/// 与Process多对一
	/// 与Node多对一
	public class Line:Entity
	{
		/// <summary>
		/// 标签：无,是,否
		/// </summary>
		public string Lable { get; set; }

		/// <summary>
		/// 起始节点：外键到节点
		/// </summary>
		public Guid StartNodeID { get; set; }

		/// <summary>
		/// 结束节点：外键到节点
		/// </summary>
		public Guid EndNodeID { get; set; }

		/// <summary>
		/// 外键到Process
		/// </summary>
		public Guid ProcessID { get; set; }

		[ForeignKey("StartNodeID")]
		public virtual Node StartNode { get; set; }

		[ForeignKey("EndNodeID")]
		public virtual Node EndNode { get; set; }

		[ForeignKey("ProcessID")]
		public virtual Process Process { get; set; }
	}
}