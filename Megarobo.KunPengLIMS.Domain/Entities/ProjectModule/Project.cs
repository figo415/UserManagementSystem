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
	public class Project:AuditableEntity
	{
		/// <summary>
		/// ��Ŀ����
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// ���������
		/// </summary>
		public Guid ProcessId { get; set; }

		[ForeignKey("ProcessId")]
		public Process Process { get; set; }

		/// <summary>
		/// �ƻ���ʼʱ��
		/// </summary>
		public DateTime? PlannedStartTime { get; set; }

		/// <summary>
		/// ��Ŀ״̬���Ѵ����������С�����ֹ������ɡ�
		/// ����һ��take�������Ŀ״̬����Ϊ�����
		/// �����в����޸�
		/// �����Ŀ�Ѿ��ڽ����оͲ����޸����̣��޸ı��������ų�
		/// ��Ŀ�����в���ɾ��
		/// </summary>
		public string Status { get; set; }

		public virtual ICollection<ProjectUser> Users { get; set; }

		/// <summary>
		/// Take�б�ͨ������ĸ�ӹ�ϵ����
		/// </summary>
		public virtual ICollection<Take> Takes { get; set; }

		///// <summary>
		///// ������û�
		///// </summary>
		//public Guid ProjectManagerId { get; set; }

		///// <summary>
		///// ������û�
		///// </summary>
		//public Guid ARDId { get; set; }

		///// <summary>
		///// ������û�
		///// </summary>
		//public Guid FRDId { get; set; }

		///// <summary>
		///// ������û�
		///// </summary>
		//public Guid SRDId { get; set; }

		//[ForeignKey("ProjectManagerId")]
		//public User ProjectManager { get; set; }

		//[ForeignKey("ARDId")]
		//public User ARD { get; set; }

		//[ForeignKey("FRDId")]
		//public User FRD { get; set; }

		//[ForeignKey("SRDId")]
		//public User SRD { get; set; }

		/// <summary>
		/// �����б�
		/// </summary>
		//public List<Task> Tasks { get; set; }
		public virtual ICollection<ProjectTask> Tasks { get; set; }
	}
}