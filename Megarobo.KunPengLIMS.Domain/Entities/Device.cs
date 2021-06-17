using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 设备
	/// </summary>
	/// 与Node多对多
	/// 与DeviceParameter一对多
	/// 与Position一对多
	/// 与Task一对多
	public class Device:Entity
	{
		public string Name { get; set; }

		/// <summary>
		/// 培养箱,PCR,移液工作站,货架
		/// </summary>
		public string SubClass { get; set; }

		public virtual ICollection<NodeDevice> Nodes { get; set; }

		public virtual ICollection<DeviceParameter> DeviceParameters { get; set; }

		public virtual ICollection<Position> Positions { get; set; }

		public virtual ICollection<Task> Tasks { get; set; }
	}
}
