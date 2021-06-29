using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 耗材
	/// </summary>
	/// 与Position多对多
	/// 与Node多对多
	/// 与Task多对多
	public class Labware:PurchasableEntity
	{
		/// <summary>
		/// 耗材名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 耗材类型：存储(样本试剂),移液,配件
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 耗材子类：6孔板,12孔板,24孔板,48孔板,96孔板,1.5mL管,15mL管,50mL管
		/// </summary>
		public string Subclass { get; set; }

		/// <summary>
		/// 货号
		/// </summary>
		public string ArticleNumber { get; set; }

		/// <summary>
		/// 品牌：ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// 规格
		/// </summary>
		public string Specification { get; set; }

		/// <summary>
		/// 可用量：0~100000000
		/// </summary>
		public int AvailableQuantity { get; set; }

		/// <summary>
		/// 可用孔位数
		/// </summary>
		public int AvailableHole { get; set; }

		public string Barcode { get; set; }

		/// <summary>
		/// 消失时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// 位置列表
		/// </summary>
		//public List<Position> Positions;
		public virtual ICollection<LabwarePosition> Positions { get; set; }

		public virtual ICollection<NodeLabware> Nodes { get; set; }

		public virtual ICollection<TaskLabware> Tasks { get; set; }
	}
}