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
	public class Node:Entity
	{
		/// <summary>
		/// �豸�б�
		/// </summary>
		//public List<Device> Devices { get; set; }
		public virtual ICollection<NodeDevice> Devices { get; set; }

		/// <summary>
		/// �豸��������
		/// </summary>
		public string DeviceSearchString { get; set; }

		/// <summary>
		/// �������ʱ��:Ƕ��ֵ����ʱ����
		/// </summary>
		public TimeInterval Duration { get; set; }

		/// <summary>
		/// ����ʱ���б�:Ƕ��ֵ����ʱ������
		/// </summary>
		public Period InteractiveTimes { get; set; }

		/// <summary>
		/// �Ĳ��б�
		/// </summary>
		//public List<Labware> Labwares { get; set; }
		public virtual ICollection<NodeLabware> Labwares { get; set; }

		/// <summary>
		/// �Ĳ���������
		/// </summary>
		public string LabwareSearchString { get; set; }

		/// <summary>
		/// ������ڵ�����
		/// </summary>
		public Guid NodeTypeID { get; set; }

		[ForeignKey("NodeTypeID")]
		public NodeType NodeType { get; set; }

		/// <summary>
		/// ProtocolStep�б�
		/// </summary>
		//public List<ProtocolStep> Protocols { get; set; }
		public virtual ICollection<NodeProtocolStep> ProtocolSteps { get; set; }

		/// <summary>
		/// �Լ��б�
		/// </summary>
		//public List<Reagent> Reagents { get; set; }
		public virtual ICollection<NodeReagent> Reagents { get; set; }

		/// <summary>
		/// �Լ���������
		/// </summary>
		public string ReagentSearchString { get; set; }

        public virtual ICollection<Line> StartLines { get; set; } = new List<Line>();

        public virtual ICollection<Line> EndLines { get; set; } = new List<Line>();

        public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// �������
		/// </summary>
		/// undefined
		public int ResultSample { get; set; }

		/// <summary>
		/// �账������
		/// </summary>
		/// undefined
		public int Samples { get; set; }
	}
}