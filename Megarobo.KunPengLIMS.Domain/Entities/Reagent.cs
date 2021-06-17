using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 试剂
	/// </summary>
	/// 与Node多对多
	/// 与Position多对多
	/// 与ReagentDosage一对多
	/// 与Task多对多
	public class Reagent:Entity
	{
		/// <summary>
		/// 货号
		/// </summary>
		public string ArticleNumber { get; set; }

		public string Barcode { get; set; }

		/// <summary>
		/// 购买来源:嵌入值对象：链接
		/// </summary>
		public Link BoughtFrom { get; set; }

		/// <summary>
		/// 品牌：ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// 产生时间:yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// 可用体积:嵌入值对象：体积
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// 消失时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		public string Name { get; set; }

		/// <summary>
		/// 购买价格:嵌入值对象：价格
		/// </summary>
		public Price Price { get; set; }

		/// <summary>
		/// 购买日期：yyyy-MM-dd
		/// </summary>
		public DateTime PurchaseDate { get; set; }

		/// <summary>
		/// 质量规格:嵌入值对象：质量
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// 状态：存活,消失
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 供应商：ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen
		/// </summary>
		public string Supplier { get; set; }

		/// <summary>
		/// 浓度规格：嵌入值对象：浓度
		/// </summary>
		public Thickness Thickness { get; set; }

		/// <summary>
		/// 试剂类型：转染试剂,抗体,化学品,试剂盒,培养基,血清,抗生素
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 可用质量:嵌入值对象：质量
		/// </summary>
		public Quality UnusedQuality { get; set; }

		/// <summary>
		/// 更新时间:yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime UpdatedTime { get; set; }

		/// <summary>
		/// 位置列表
		/// </summary>
		//public List<Position> Positions { get; set; }
		public virtual ICollection<ReagentPosition> Positions { get; set; }


		public virtual ICollection<NodeReagent> Nodes { get; set; }

		public virtual ICollection<ReagentDosage> ReagentDosages { get; set; }

		//public Guid TaskID { get; set; }

		//[ForeignKey("TaskID")]
		//public Task Task { get; set; }
		public virtual ICollection<TaskReagent> Tasks { get; set; }
	}
}