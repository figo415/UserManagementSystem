//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// 位置
//	/// </summary>
//	/// 与Device多对多
//	/// 与Labware多对多
//	/// 与Reagent多对多
//	/// 与Sample多对多
//	public class Position:Entity
//	{
//		public string Name { get; set; }

//		/// <summary>
//		/// 孔位：1~10000
//		/// </summary>
//		public int Hole { get; set; }

//		/// <summary>
//		/// 层：1~10
//		/// </summary>
//		public int Layer { get; set; }

//		/// <summary>
//		/// 房间：细胞1,细胞2,分子1,分子2
//		/// </summary>
//		public string Room { get; set; }

//		/// <summary>
//		/// 1~10
//		/// </summary>
//		public int Tower { get; set; }

//		/// <summary>
//		/// A1,A2,A3,B1,B2,B3
//		/// </summary>
//		public string Well { get; set; }

//		/// <summary>
//		/// 区域：区域1,区域2
//		/// </summary>
//		public string Zone { get; set; }

//		public Guid ParentId { get; set; }

//		///// <summary>
//		///// 外键到设备
//		///// </summary>
//		//public Guid DeviceID { get; set; }

//		//[ForeignKey("DeviceID")]
//		//public Device Device { get; set; }
//		public virtual ICollection<DevicePosition> Devices { get; set; }

//		public virtual ICollection<LabwarePosition> Labwares { get; set; }

//		public virtual ICollection<ReagentPosition> Reagents { get; set; }

//		public virtual ICollection<SamplePosition> Samples { get; set; }
//	}
//}