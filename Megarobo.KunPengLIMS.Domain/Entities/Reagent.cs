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
	public class Reagent:Entity
	{
		/// <summary>
		/// ����
		/// </summary>
		public string ArticleNumber { get; set; }

		public string Barcode { get; set; }

		/// <summary>
		/// ������Դ:Ƕ��ֵ��������
		/// </summary>
		public Link BoughtFrom { get; set; }

		/// <summary>
		/// Ʒ�ƣ�ThermoFisher,ȫʽ��,ŵά��,������,Gibco,Merck,invitrogen
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// ����ʱ��:yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// �������:Ƕ��ֵ�������
		/// </summary>
		public Cubage Cubage { get; set; }

		/// <summary>
		/// ��ʧʱ�䣺yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime DeletedTime { get; set; }

		public string Name { get; set; }

		/// <summary>
		/// ����۸�:Ƕ��ֵ���󣺼۸�
		/// </summary>
		public Price Price { get; set; }

		/// <summary>
		/// �������ڣ�yyyy-MM-dd
		/// </summary>
		public DateTime PurchaseDate { get; set; }

		/// <summary>
		/// �������:Ƕ��ֵ��������
		/// </summary>
		public Quality Quality { get; set; }

		/// <summary>
		/// ��ע
		/// </summary>
		public string Remarks { get; set; }

		/// <summary>
		/// ״̬�����,��ʧ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ��Ӧ�̣�ThermoFisher,ȫʽ��,ŵά��,������,Gibco,Merck,invitrogen
		/// </summary>
		public string Supplier { get; set; }

		/// <summary>
		/// Ũ�ȹ��Ƕ��ֵ����Ũ��
		/// </summary>
		public Thickness Thickness { get; set; }

		/// <summary>
		/// �Լ����ͣ�תȾ�Լ�,����,��ѧƷ,�Լ���,������,Ѫ��,������
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// ��������:Ƕ��ֵ��������
		/// </summary>
		public Quality UnusedQuality { get; set; }

		/// <summary>
		/// ����ʱ��:yyyy-MM-dd hh:mm:ss
		/// </summary>
		public DateTime UpdatedTime { get; set; }

		/// <summary>
		/// λ���б�
		/// </summary>
		//public List<Position> Positions { get; set; }
		public virtual ICollection<ReagentPosition> Positions { get; set; }


		public virtual ICollection<NodeReagent> Nodes { get; set; }

		public virtual ICollection<ReagentDosage> ReagentDosages { get; set; }

		//public Guid TaskID { get; set; }

		//[ForeignKey("TaskID")]
		//public Task Task { get; set; }
		public virtual ICollection<TaskReagent> Tasks { get; set; }
	}
}