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
	public class Project:Entity
	{
		public string Name { get; set; }

		/// <summary>
		/// 项目状态：未开始,进行中,完成,终止
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 外键到用户
		/// </summary>
		public Guid ProjectManagerID { get; set; }

		/// <summary>
		/// 外键到用户
		/// </summary>
		public Guid ARDID { get; set; }

		/// <summary>
		/// 外键到用户
		/// </summary>
		public Guid FRDID { get; set; }

		/// <summary>
		/// 外键到用户
		/// </summary>
		public Guid SRDID { get; set; }

		/// <summary>
		/// 外键到流程
		/// </summary>
		public Guid ProcessID { get; set; }

		[ForeignKey("ProjectManagerID")]
		public User ProjectManager { get; set; }

		[ForeignKey("ARDID")]
		public User ARD { get; set; }

		[ForeignKey("FRDID")]
		public User FRD { get; set; }

		[ForeignKey("SRDID")]
		public User SRD { get; set; }

		[ForeignKey("ProcessID")]
		public Process Process { get; set; }

		/// <summary>
		/// 任务列表
		/// </summary>
		//public List<Task> Tasks { get; set; }
		public virtual ICollection<ProjectTask> Tasks { get; set; }

		/// <summary>
		/// Take列表，通过任务母子关系生成
		/// </summary>
		public virtual ICollection<Take> Takes { get; set; }
	}
}