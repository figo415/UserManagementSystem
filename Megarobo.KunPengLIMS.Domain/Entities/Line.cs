using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ����
	/// </summary>
	/// ��Process���һ
	/// ��Node���һ
	public class Line:Entity
	{
		/// <summary>
		/// ��ǩ����,��,��
		/// </summary>
		public string Lable { get; set; }

		/// <summary>
		/// ��ʼ�ڵ㣺������ڵ�
		/// </summary>
		public Guid StartNodeID { get; set; }

		/// <summary>
		/// �����ڵ㣺������ڵ�
		/// </summary>
		public Guid EndNodeID { get; set; }

		/// <summary>
		/// �����Process
		/// </summary>
		public Guid ProcessID { get; set; }

		[ForeignKey("StartNodeID")]
		public virtual Node StartNode { get; set; }

		[ForeignKey("EndNodeID")]
		public virtual Node EndNode { get; set; }

		[ForeignKey("ProcessID")]
		public virtual Process Process { get; set; }
	}
}