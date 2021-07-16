using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 流程
	/// </summary>
	/// 与Line一对多
	/// 与Project一对多
	public class Process:AuditableEntity
	{
		public string Name { get; set; }

		/// <summary>
		/// 流程类型：项目流程,系统流程
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 连线列表
		/// </summary>
		public List<Line> Lines { get; set; }

		/// <summary>
		/// 节点列表:通过连线生成
		/// </summary>
		public List<Node> Nodes { get; }

		/// <summary>
		/// 关联的项目列表
		/// </summary>
		public List<Project> Projects { get; set; }
	}
}