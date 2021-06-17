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
	public class Node:Entity
	{
		/// <summary>
		/// 设备列表
		/// </summary>
		//public List<Device> Devices { get; set; }
		public virtual ICollection<NodeDevice> Devices { get; set; }

		/// <summary>
		/// 设备搜索条件
		/// </summary>
		public string DeviceSearchString { get; set; }

		/// <summary>
		/// 任务持续时间:嵌入值对象：时间间隔
		/// </summary>
		public TimeInterval Duration { get; set; }

		/// <summary>
		/// 交互时间列表:嵌入值对象：时间区间
		/// </summary>
		public Period InteractiveTimes { get; set; }

		/// <summary>
		/// 耗材列表
		/// </summary>
		//public List<Labware> Labwares { get; set; }
		public virtual ICollection<NodeLabware> Labwares { get; set; }

		/// <summary>
		/// 耗材搜索条件
		/// </summary>
		public string LabwareSearchString { get; set; }

		/// <summary>
		/// 外键到节点类型
		/// </summary>
		public Guid NodeTypeID { get; set; }

		[ForeignKey("NodeTypeID")]
		public NodeType NodeType { get; set; }

		/// <summary>
		/// ProtocolStep列表
		/// </summary>
		//public List<ProtocolStep> Protocols { get; set; }
		public virtual ICollection<NodeProtocolStep> ProtocolSteps { get; set; }

		/// <summary>
		/// 试剂列表
		/// </summary>
		//public List<Reagent> Reagents { get; set; }
		public virtual ICollection<NodeReagent> Reagents { get; set; }

		/// <summary>
		/// 试剂搜索条件
		/// </summary>
		public string ReagentSearchString { get; set; }

        public virtual ICollection<Line> StartLines { get; set; } = new List<Line>();

        public virtual ICollection<Line> EndLines { get; set; } = new List<Line>();

        public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// 结果样本
		/// </summary>
		/// undefined
		public int ResultSample { get; set; }

		/// <summary>
		/// 需处理样本
		/// </summary>
		/// undefined
		public int Samples { get; set; }
	}
}