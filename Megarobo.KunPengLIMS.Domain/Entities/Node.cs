using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 节点
	/// </summary>
	/// 与NodeType多对一
	/// 与Device多对多
	/// 与Labware多对多
	/// 与Line一对多
	/// 与ProtocolStep多对多
	/// 与Reagent多对多
	/// 与Task一对多
	public class Node:AuditableEntity
	{
		/// <summary>
		/// 节点名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 外键到节点类型
		/// </summary>
		public Guid NodeTypeId { get; set; }

		[ForeignKey("NodeTypeId")]
		public Skill NodeType { get; set; }

		/// <summary>
		/// 任务持续时间
		/// </summary>
		public TimeInterval Duration { get; set; }

		/// <summary>
		/// 交互时间列表
		/// </summary>
		//public Period InteractiveTimes { get; set; }
		public string InteractiveTime { get; set; }

		/// <summary>
		/// 等待执行时间：下次拍照的时间（时间段）
		/// </summary>
		public string TimeWaitToRun { get; set; }

		/// <summary>
		/// 是否生成结果样本
		/// </summary>
		public bool CanGenerateResultSample { get; set; }

		/// <summary>
		/// 是否生成结果文件
		/// </summary>
		public bool CanGenerateResultFile { get; set; }

		/// <summary>
		/// ProtocolStep列表
		/// </summary>
		//public List<ProtocolStep> Protocols { get; set; }
		public virtual ICollection<NodeProtocolStep> ProtocolSteps { get; set; }

        public virtual ICollection<Line> StartLines { get; set; } = new List<Line>();

        public virtual ICollection<Line> EndLines { get; set; } = new List<Line>();

        public virtual ICollection<Task> Tasks { get; set; }
	}
}