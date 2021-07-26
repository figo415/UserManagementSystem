using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 任务
	/// </summary>
	/// 与Labware多对多
	/// 与Project多对多
	/// 与Sample多对多
	/// 与Take多对多
	/// 与Node多对一
	/// 与User多对多
	/// 与Reagent多对多
	/// 与Device多对一
	/// 与ProtocolStep多对一
	public class Task:Entity
	{
		/// <summary>
		/// 外键到设备
		/// </summary>
		public Guid DeviceId { get; set; }

		/// <summary>
		/// yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 任务状态：未开始,进行中,完成,终止
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 外键到节点
		/// </summary>
		public Guid NodeId { get; set; }

		/// <summary>
		/// 母任务列表
		/// </summary>
		//public List<Task> ParentTasks { get; set; }
		public Guid ParentId { get; set; }

		/// <summary>
		/// 外键到ProtocolStep
		/// </summary>
		public Guid ProtocolId { get; set; }

		/// <summary>
		/// Take号
		/// </summary>
		public Guid TakeId { get; set; }

		/// <summary>
		/// 结果附件:文件列表
		/// </summary>
		public List<File> ResultAttachments { get; set; }

		//[ForeignKey("TakeID")]
		//public Take Take { get; set; }

		[ForeignKey("DeviceId")]
		public virtual Device Device { get; set; }

		[ForeignKey("NodeId")]
		public virtual Node Node { get; set; }

		[ForeignKey("ProtocolId")]
		public ProtocolStep ProtocolStep { get; set; }

		/// <summary>
		/// 耗材列表
		/// </summary>
		//public List<Labware> Labwares { get; set; }
		public virtual ICollection<TaskLabware> Labwares { get; set; }

		/// <summary>
		/// 外键到项目
		/// </summary>
		//public Guid ProjectID { get; set; }

		//[ForeignKey("ProjectID")]
		//public Project Project { get; set; }
		public virtual ICollection<ProjectTask> Projects { get; set; }

		/// <summary>
		/// 试剂列表
		/// </summary>
		//public List<Reagent> Reagents { get; set; }
		public virtual ICollection<TaskReagent> Reagents { get; set; }

		/// <summary>
		/// 结果样本列表
		/// </summary>
		//public List<Sample> ResultSamples { get; set; }
		[NotMapped]
		public List<Sample> ResultSamples { get; set; }

		/// <summary>
		/// 需处理样本列表
		/// </summary>
		//public List<Sample> UnhandledSamples { get; set; }
		[NotMapped]
		public List<Sample> UnhandledSamples { get; set; }

		public virtual ICollection<TaskSample> Samples { get; set; }

		/// <summary>
		/// 用户列表
		/// </summary>
		public virtual ICollection<TaskUser> Users { get; set; }

		public virtual ICollection<TakeTask> Takes { get; set; }
	}
}