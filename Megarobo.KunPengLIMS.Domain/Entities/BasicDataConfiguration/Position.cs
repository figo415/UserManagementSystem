//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// λ��
//	/// </summary>
//	/// ��Device��Զ�
//	/// ��Labware��Զ�
//	/// ��Reagent��Զ�
//	/// ��Sample��Զ�
//	public class Position:Entity
//	{
//		public string Name { get; set; }

//		/// <summary>
//		/// ��λ��1~10000
//		/// </summary>
//		public int Hole { get; set; }

//		/// <summary>
//		/// �㣺1~10
//		/// </summary>
//		public int Layer { get; set; }

//		/// <summary>
//		/// ���䣺ϸ��1,ϸ��2,����1,����2
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
//		/// ��������1,����2
//		/// </summary>
//		public string Zone { get; set; }

//		public Guid ParentId { get; set; }

//		///// <summary>
//		///// ������豸
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