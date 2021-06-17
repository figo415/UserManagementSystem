using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 设备使用参数
	/// </summary>
	/// 与Device多对一
	/// 与ProtocolStep一对多
	public class DeviceParameter:Entity
	{
		public string Note{ get; set; }

		/// <summary>
		/// 嵌入值对象：转速
		/// </summary>
		public RotationRate RotationRate;

		/// <summary>
		/// 嵌入值对象：文件
		/// </summary>
		public File Script { get; set; }

		/// <summary>
		/// 嵌入值对象：温度
		/// </summary>
		public Temperature Temprature;

		/// <summary>
		/// 嵌入值对象：时间间隔
		/// </summary>
		public TimeInterval TimeInterval;

		/// <summary>
		/// 外键到设备
		/// </summary>
		public Guid DeviceID;

		[ForeignKey("DeviceID")]
		public Device Device { get; set; }

		public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; }
	}
}
