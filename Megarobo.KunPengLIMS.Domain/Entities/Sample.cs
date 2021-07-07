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
	/// ��Task��Զ�
	/// ��SampleDosageһ�Զ�
	/// ��Position��Զ�
	public class Sample:PurchasableEntity
	{
		/// <summary>
		/// ��������
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// �������ͣ�ϸ��,����,������,����
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// ���
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// Ũ��
		/// </summary>
		public Thickness Thickness { get; set; }

		///// <summary>
		///// �����λ��
		///// </summary>
		///// undefined
		//public Guid PositionId { get; set; }

		/// <summary>
		/// ��ʧʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// �´�����ʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime NextPhotoTime { get; set; }

		/// <summary>
		/// ״̬�����,��ʧ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ��ʵ����������������
		/// </summary>
		public bool IsRealSample { get; set; }

		/// <summary>
		/// ϸ�����ࣺ�����ϸ��ϵ
		/// </summary>
		//private int CellID;
		public Guid CellId { get; set; }

		[ForeignKey("CellId")]
		public Cell Cell { get; set; }

		/// <summary>
		/// ���������ࣺ�����������
		/// </summary>
		//private int GenomeID;

		/// <summary>
		/// �������ࣺ���������
		/// </summary>
		//private int PlasmidID;

		/// <summary>
		/// ���������ࣺ�����������
		/// </summary>
		//private int ProteinID;

		/// <summary>
		/// RNA���ࣺ�����RNA
		/// </summary>
		//private int RNAID;

		//[ForeignKey("PositionId")]
		//public Position Position { get; set; }

		/// <summary>
		/// ��Դ�������������
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