using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �Ĳ�
	/// </summary>
	/// ��Position��Զ�
	/// ��Node��Զ�
	/// ��Task��Զ�
	public class Labware:PurchasableEntity
	{
		/// <summary>
		/// �Ĳ�����
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// �Ĳ����ͣ��洢(�����Լ�),��Һ,���
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// �Ĳ����ࣺ6�װ�,12�װ�,24�װ�,48�װ�,96�װ�,1.5mL��,15mL��,50mL��
		/// </summary>
		public string Subclass { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string ArticleNumber { get; set; }

		/// <summary>
		/// Ʒ�ƣ�ThermoFisher,ȫʽ��,ŵά��,������,Gibco,Merck,invitrogen
		/// </summary>
		public string Brand { get; set; }

		/// <summary>
		/// ���
		/// </summary>
		public string Specification { get; set; }

		/// <summary>
		/// ��������0~100000000
		/// </summary>
		public int AvailableQuantity { get; set; }

		/// <summary>
		/// ���ÿ�λ��
		/// </summary>
		public int AvailableHole { get; set; }

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
		//public List<Position> Positions;
		public virtual ICollection<LabwarePosition> Positions { get; set; }

		public virtual ICollection<NodeLabware> Nodes { get; set; }

		public virtual ICollection<TaskLabware> Tasks { get; set; }
	}
}