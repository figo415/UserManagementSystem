using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �ڵ�
	/// </summary>
	/// ��NodeType���һ
	/// ��Device��Զ�
	/// ��Labware��Զ�
	/// ��Lineһ�Զ�
	/// ��ProtocolStep��Զ�
	/// ��Reagent��Զ�
	/// ��Taskһ�Զ�
	public class Node:AuditableEntity
	{
		/// <summary>
		/// �ڵ�����
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// ������ڵ�����
		/// </summary>
		public Guid NodeTypeId { get; set; }

		[ForeignKey("NodeTypeId")]
		public Skill NodeType { get; set; }

		/// <summary>
		/// �������ʱ��
		/// </summary>
		public TimeInterval Duration { get; set; }

		/// <summary>
		/// ����ʱ���б�
		/// </summary>
		//public Period InteractiveTimes { get; set; }
		public string InteractiveTime { get; set; }

		/// <summary>
		/// �ȴ�ִ��ʱ�䣺�´����յ�ʱ�䣨ʱ��Σ�
		/// </summary>
		public string TimeWaitToRun { get; set; }

		/// <summary>
		/// �Ƿ����ɽ������
		/// </summary>
		public bool CanGenerateResultSample { get; set; }

		/// <summary>
		/// �Ƿ����ɽ���ļ�
		/// </summary>
		public bool CanGenerateResultFile { get; set; }

		/// <summary>
		/// ProtocolStep�б�
		/// </summary>
		//public List<ProtocolStep> Protocols { get; set; }
		public virtual ICollection<NodeProtocolStep> ProtocolSteps { get; set; }

        public virtual ICollection<Line> StartLines { get; set; } = new List<Line>();

        public virtual ICollection<Line> EndLines { get; set; } = new List<Line>();

        public virtual ICollection<Task> Tasks { get; set; }
	}
}