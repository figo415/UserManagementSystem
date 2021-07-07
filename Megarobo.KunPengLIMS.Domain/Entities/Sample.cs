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
	/// 与Position多对多
	public class Sample:PurchasableEntity
	{
		/// <summary>
		/// 样本名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 样本类型：细胞,核酸,蛋白质,抗体
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// 样本描述
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// 体积
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// 质量
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// 浓度
		/// </summary>
		public Thickness Thickness { get; set; }

		///// <summary>
		///// 外键到位置
		///// </summary>
		///// undefined
		//public Guid PositionId { get; set; }

		/// <summary>
		/// 消失时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// 下次拍摄时间：yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime NextPhotoTime { get; set; }

		/// <summary>
		/// 状态：存活,消失
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// 真实样本或者虚拟样本
		/// </summary>
		public bool IsRealSample { get; set; }

		/// <summary>
		/// 细胞子类：外键到细胞系
		/// </summary>
		//private int CellID;
		public Guid CellId { get; set; }

		[ForeignKey("CellId")]
		public Cell Cell { get; set; }

		/// <summary>
		/// 基因组子类：外键到基因组
		/// </summary>
		//private int GenomeID;

		/// <summary>
		/// 质粒子类：外键到质粒
		/// </summary>
		//private int PlasmidID;

		/// <summary>
		/// 蛋白质子类：外键到蛋白质
		/// </summary>
		//private int ProteinID;

		/// <summary>
		/// RNA子类：外键到RNA
		/// </summary>
		//private int RNAID;

		//[ForeignKey("PositionId")]
		//public Position Position { get; set; }

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

		public virtual ICollection<SamplePosition> Positions { get; set; }
	}
}