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
	public class Sample:Entity
	{
		/// <summary>
		/// ������Դ:Ƕ��ֵ��������
		/// </summary>
		public Link BoughtFrom { get; set; }

		/// <summary>
		/// �������ࣺϸ��,����,������,����
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// ϸ�����ࣺ�����ϸ��ϵ
		/// </summary>
		//private int CellID;

		/// <summary>
		/// ����ʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// ��ʧʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// ���������ࣺ�����������
		/// </summary>
		//private int GenomeID;

		public string Name { get; set; }

		/// <summary>
		/// �´�����ʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime NextPhotoTime { get; set; }

		/// <summary>
		/// �������ࣺ���������
		/// </summary>
		//private int PlasmidID;

		/// <summary>
		/// �����λ��
		/// </summary>
		/// undefined
		public Guid PositionID;

		[ForeignKey("PositionID")]
		public Position Position { get; set; }

		/// <summary>
		/// ����۸�:Ƕ��ֵ���󣺼۸�
		/// </summary>
		public Price Price { get; set; }

		/// <summary>
		/// ���������ࣺ�����������
		/// </summary>
		//private int ProteinID;

		/// <summary>
		/// �������ڣ�yyyy-MM-dd
		/// </summary>
		public DateTime PurchaseDate { get; set; }

		/// <summary>
		/// ��ע
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// RNA���ࣺ�����RNA
		/// </summary>
		//private int RNAID;

		/// <summary>
		/// ״̬�����,��ʧ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ��Ӧ�̣�ThermoFisher,ȫʽ��,ŵά��,������,Gibco,Merck,invitrogen
		/// </summary>
		public string Supplier { get; set; }

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

	}
}