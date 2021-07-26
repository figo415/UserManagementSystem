using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �Լ�
	/// </summary>
	/// ��Node��Զ�
	/// ��Position��Զ�
	/// ��ReagentDosageһ�Զ�
	/// ��Task��Զ�
	public class Reagent:PurchasableEntity
	{
		/// <summary>
		/// �Լ�����
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// �Լ����ͣ�תȾ�Լ�,����,��ѧƷ,�Լ���,������,Ѫ��,������
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string ArticleNumber { get; set; }

		/// <summary>
		/// Ʒ�ƣ�ThermoFisher,ȫʽ��,ŵά��,������,Gibco,Merck,invitrogen
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// �������
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// Ũ�ȹ��
		/// </summary>
		public Thickness Thickness { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public Quality AvailableQuality { get; set; }

		/// <summary>
		/// �������
		/// </summary>
		public Cubage AvailableCubage { get; set; }

		public string Barcode { get; set; }

		/// <summary>
		/// ��ʧʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		/// <summary>
		/// ��ע
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// λ���б�
		/// </summary>
		//public List<Position> Positions { get; set; }
		//public virtual ICollection<ReagentPosition> Positions { get; set; }

		public virtual ICollection<NodeReagent> Nodes { get; set; }

		//public virtual ICollection<ReagentDosage> ReagentDosages { get; set; }

		//public Guid TaskID { get; set; }

		//[ForeignKey("TaskID")]
		//public Task Task { get; set; }
		public virtual ICollection<TaskReagent> Tasks { get; set; }
	}
}