//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//	/// <summary>
//	/// �ڵ�����
//	/// </summary>
//	/// ��Nodeһ�Զ�
//	public class NodeType:Entity
//	{
//		/// <summary>
//		/// �ڵ���ࣺ����,ҵ��,����
//		/// </summary>
//		public string Category { get; set; }

//		/// <summary>
//		/// �ڵ����ࣺ*,����,����,���,���幹��,׼��ϸ��,תȾ,����,����,������¡,��������,����,ʵ�����,����,����,�ж�
//		/// </summary>
//		public string GrandClass { get; set; }

//		/// <summary>
//		/// �ڵ����ࣺ*,AR,SR,���ӿ�¡,ϸ��ʵ��,����ʵ��,���Ӽ��,����,�ж�
//		/// </summary>
//		public string SubClass { get; set; }

//		public virtual ICollection<Node> Nodes { get; set; }
//	}
//}