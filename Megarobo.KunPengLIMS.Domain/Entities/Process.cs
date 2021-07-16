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
	/// ��Lineһ�Զ�
	/// ��Projectһ�Զ�
	public class Process:AuditableEntity
	{
		public string Name { get; set; }

		/// <summary>
		/// �������ͣ���Ŀ����,ϵͳ����
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// �����б�
		/// </summary>
		public List<Line> Lines { get; set; }

		/// <summary>
		/// �ڵ��б�:ͨ����������
		/// </summary>
		public List<Node> Nodes { get; }

		/// <summary>
		/// ��������Ŀ�б�
		/// </summary>
		public List<Project> Projects { get; set; }
	}
}