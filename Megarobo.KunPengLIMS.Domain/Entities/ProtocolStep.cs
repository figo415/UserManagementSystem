using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 与Node多对多
	/// 与Solution多对一
	/// 与DeviceParameter多对一
	/// 与Task一对多
	/// </summary>
	public class ProtocolStep:AuditableEntity
	{
		[Description("文字描述")]
		public string Description { get; set; }

		public string Note { get; set; }

		public Guid ParentId { get; set; }

		///// <summary>
		///// 反应体系：外键到溶液体系
		///// </summary>
		//public Guid SolutionId { get; set; }

		//[ForeignKey("SoluationId")]
		public Solution Solution { get; set; }

		public virtual ICollection<LabwareUsage> LabwareUsages { get; set; }

		/// <summary>
		/// 外键到设备使用参数
		/// </summary>
		public Guid DeviceParameterId { get; set; }

		[ForeignKey("DeviceParameterId")]
		public DeviceParameter DeviceParameter { get; set; }

		public virtual ICollection<NodeProtocolStep> Nodes { get; set; }

		public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// 子ProtocolStep列表
		/// </summary>
		//public List<ProtocolStep> SubProtocols { get; set; }
	}
}