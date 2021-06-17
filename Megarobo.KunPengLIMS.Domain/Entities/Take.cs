using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// Take
	/// </summary>
	/// 与Project多对一
	/// 与Task多对多
	public class Take:Entity
	{
		/// <summary>
		/// Take编号
		/// </summary>
		public int TakeCode { get; set; }

		/// <summary>
		/// 状态：进行中,终止
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 外键到任务
		/// </summary>
		public Guid CurrentTaskID { get; set; }

		/// <summary>
		/// 外键到项目
		/// </summary>
		public Guid ProjectID { get; set; }

		//[ForeignKey("CurrentTaskID")]
		//public Task CurrentTask { get; set; }

		/// <summary>
		/// 完成的任务列表
		/// </summary>
		[NotMapped]
		public List<Task> FinishedTasks { get; set; }

		/// <summary>
		/// 前提任务列表
		/// </summary>
		[NotMapped]
		public List<Task> PreviousTasks { get; set; }

		public virtual ICollection<TakeTask> Tasks { get; set; }

		[ForeignKey("ProjectID")]
		public virtual Project Project { get; set; }
	}
}