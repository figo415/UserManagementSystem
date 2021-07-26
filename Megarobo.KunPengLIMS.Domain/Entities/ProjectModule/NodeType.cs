//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// 节点类型
//	/// </summary>
//	/// 与Node一对多
//	public class NodeType:Entity
//	{
//		/// <summary>
//		/// 节点大类：商务,业务,控制
//		/// </summary>
//		public string Category { get; set; }

//		/// <summary>
//		/// 节点三类：*,需求,方案,设计,载体构建,准备细胞,转染,富集,扩增,挑单克隆,扩大培养,交付,实验鉴定,测序,传代,判断
//		/// </summary>
//		public string GrandClass { get; set; }

//		/// <summary>
//		/// 节点子类：*,AR,SR,分子克隆,细胞实验,生化实验,分子检测,测序,判断
//		/// </summary>
//		public string SubClass { get; set; }

//		public virtual ICollection<Node> Nodes { get; set; }
//	}
//}