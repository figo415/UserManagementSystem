using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// 样本
	/// </summary>
	/// 与Task多对多
	/// 与SampleDosage一对多
	public class Sample:Entity
	{
		/// <summary>
		/// 购买来源:嵌入值对象：链接
		/// </summary>
		public Link BoughtFrom { get; set; }

		/// <summary>
		/// 样本大类：细胞,核酸,蛋白质,抗体
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// 细胞子类：外键到细胞系
		/// </summary>
		//private int CellID;

		/// <summary>
		/// 产生时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// 消失时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// 基因组子类：外键到基因组
		/// </summary>
		//private int GenomeID;

		public string Name { get; set; }

		/// <summary>
		/// 下次拍摄时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime NextPhotoTime { get; set; }

		/// <summary>
		/// 质粒子类：外键到质粒
		/// </summary>
		//private int PlasmidID;

		/// <summary>
		/// 外键到位置
		/// </summary>
		/// undefined
		public Guid PositionID;

		[ForeignKey("PositionID")]
		public Position Position { get; set; }

		/// <summary>
		/// 购买价格:嵌入值对象：价格
		/// </summary>
		public Price Price { get; set; }

		/// <summary>
		/// 蛋白质子类：外键到蛋白质
		/// </summary>
		//private int ProteinID;

		/// <summary>
		/// 购买日期：yyyy-MM-dd
		/// </summary>
		public DateTime PurchaseDate { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// RNA子类：外键到RNA
		/// </summary>
		//private int RNAID;

		/// <summary>
		/// 状态：存活,消失
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 供应商：ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen
		/// </summary>
		public string Supplier { get; set; }

		/// <summary>
		/// 来源任务：外键到任务
		/// </summary>
		//public Guid TaskID { get; set; }
		[NotMapped]
		public Task SourceTask { get; }

		//[ForeignKey("TaskID")]
		//public Task SourceTask { get; set; }

		public virtual ICollection<TaskSample> Tasks { get; set; }

		public virtual ICollection<SampleDosage> SampleDosages { get; set; }

	}
}