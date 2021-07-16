using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 项目
	/// </summary>
	/// 与Process多对一
	/// 与Task多对多
	/// 与Take一对多
	/// 与User多对一
	public class Project:AuditableEntity
	{
		/// <summary>
		/// 项目名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 外键到流程
		/// </summary>
		public Guid ProcessId { get; set; }

		[ForeignKey("ProcessId")]
		public Process Process { get; set; }

		/// <summary>
		/// 计划开始时间
		/// </summary>
		public DateTime? PlannedStartTime { get; set; }

		/// <summary>
		/// 项目状态：已创建、进行中、已终止、已完成。
		/// 至少一个take已完成项目状态更新为已完成
		/// 进行中不可修改
		/// 如果项目已经在进行中就不能修改流程，修改保持重新排程
		/// 项目进行中不可删除
		/// </summary>
		public string Status { get; set; }

		public virtual ICollection<ProjectUser> Users { get; set; }

		/// <summary>
		/// Take列表，通过任务母子关系生成
		/// </summary>
		public virtual ICollection<Take> Takes { get; set; }

		///// <summary>
		///// 外键到用户
		///// </summary>
		//public Guid ProjectManagerId { get; set; }

		///// <summary>
		///// 外键到用户
		///// </summary>
		//public Guid ARDId { get; set; }

		///// <summary>
		///// 外键到用户
		///// </summary>
		//public Guid FRDId { get; set; }

		///// <summary>
		///// 外键到用户
		///// </summary>
		//public Guid SRDId { get; set; }

		//[ForeignKey("ProjectManagerId")]
		//public User ProjectManager { get; set; }

		//[ForeignKey("ARDId")]
		//public User ARD { get; set; }

		//[ForeignKey("FRDId")]
		//public User FRD { get; set; }

		//[ForeignKey("SRDId")]
		//public User SRD { get; set; }

		/// <summary>
		/// 任务列表
		/// </summary>
		//public List<Task> Tasks { get; set; }
		public virtual ICollection<ProjectTask> Tasks { get; set; }
	}
}