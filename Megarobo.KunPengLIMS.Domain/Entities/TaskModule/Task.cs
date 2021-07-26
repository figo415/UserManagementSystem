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
	/// ��Labware��Զ�
	/// ��Project��Զ�
	/// ��Sample��Զ�
	/// ��Take��Զ�
	/// ��Node���һ
	/// ��User��Զ�
	/// ��Reagent��Զ�
	/// ��Device���һ
	/// ��ProtocolStep���һ
	public class Task:Entity
	{
		/// <summary>
		/// ������豸
		/// </summary>
		public Guid DeviceId { get; set; }

		/// <summary>
		/// yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// ����״̬��δ��ʼ,������,���,��ֹ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ������ڵ�
		/// </summary>
		public Guid NodeId { get; set; }

		/// <summary>
		/// ĸ�����б�
		/// </summary>
		//public List<Task> ParentTasks { get; set; }
		public Guid ParentId { get; set; }

		/// <summary>
		/// �����ProtocolStep
		/// </summary>
		public Guid ProtocolId { get; set; }

		/// <summary>
		/// Take��
		/// </summary>
		public Guid TakeId { get; set; }

		/// <summary>
		/// �������:�ļ��б�
		/// </summary>
		public List<File> ResultAttachments { get; set; }

		//[ForeignKey("TakeID")]
		//public Take Take { get; set; }

		[ForeignKey("DeviceId")]
		public virtual Device Device { get; set; }

		[ForeignKey("NodeId")]
		public virtual Node Node { get; set; }

		[ForeignKey("ProtocolId")]
		public ProtocolStep ProtocolStep { get; set; }

		/// <summary>
		/// �Ĳ��б�
		/// </summary>
		//public List<Labware> Labwares { get; set; }
		public virtual ICollection<TaskLabware> Labwares { get; set; }

		/// <summary>
		/// �������Ŀ
		/// </summary>
		//public Guid ProjectID { get; set; }

		//[ForeignKey("ProjectID")]
		//public Project Project { get; set; }
		public virtual ICollection<ProjectTask> Projects { get; set; }

		/// <summary>
		/// �Լ��б�
		/// </summary>
		//public List<Reagent> Reagents { get; set; }
		public virtual ICollection<TaskReagent> Reagents { get; set; }

		/// <summary>
		/// ��������б�
		/// </summary>
		//public List<Sample> ResultSamples { get; set; }
		[NotMapped]
		public List<Sample> ResultSamples { get; set; }

		/// <summary>
		/// �账�������б�
		/// </summary>
		//public List<Sample> UnhandledSamples { get; set; }
		[NotMapped]
		public List<Sample> UnhandledSamples { get; set; }

		public virtual ICollection<TaskSample> Samples { get; set; }

		/// <summary>
		/// �û��б�
		/// </summary>
		public virtual ICollection<TaskUser> Users { get; set; }

		public virtual ICollection<TakeTask> Takes { get; set; }
	}
}