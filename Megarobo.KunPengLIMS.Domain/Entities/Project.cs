using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ��Ŀ
	/// </summary>
	/// ��Process���һ
	/// ��Task��Զ�
	/// ��Takeһ�Զ�
	/// ��User���һ
	public class Project:Entity
	{
		public string Name { get; set; }

		/// <summary>
		/// ��Ŀ״̬��δ��ʼ,������,���,��ֹ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ������û�
		/// </summary>
		public Guid ProjectManagerID { get; set; }

		/// <summary>
		/// ������û�
		/// </summary>
		public Guid ARDID { get; set; }

		/// <summary>
		/// ������û�
		/// </summary>
		public Guid FRDID { get; set; }

		/// <summary>
		/// ������û�
		/// </summary>
		public Guid SRDID { get; set; }

		/// <summary>
		/// ���������
		/// </summary>
		public Guid ProcessID { get; set; }

		[ForeignKey("ProjectManagerID")]
		public User ProjectManager { get; set; }

		[ForeignKey("ARDID")]
		public User ARD { get; set; }

		[ForeignKey("FRDID")]
		public User FRD { get; set; }

		[ForeignKey("SRDID")]
		public User SRD { get; set; }

		[ForeignKey("ProcessID")]
		public Process Process { get; set; }

		/// <summary>
		/// �����б�
		/// </summary>
		//public List<Task> Tasks { get; set; }
		public virtual ICollection<ProjectTask> Tasks { get; set; }

		/// <summary>
		/// Take�б�ͨ������ĸ�ӹ�ϵ����
		/// </summary>
		public virtual ICollection<Take> Takes { get; set; }
	}
}