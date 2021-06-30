using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �豸
	/// </summary>
	/// ��Node��Զ�
	/// ��DeviceParameterһ�Զ�
	/// ��Position��Զ�
	/// ��Taskһ�Զ�
	public class Device:PurchasableEntity
	{
		/// <summary>
		/// �豸����
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// �豸���ͣ�������,PCR,��Һ����վ,����
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// �豸�ͺ�
		/// </summary>
		public string ModelNumber { get; set; }

		/// <summary>
		/// Ʒ��
		/// </summary>
		public string Brand { get; set; }

		public virtual ICollection<NodeDevice> Nodes { get; set; }

		public virtual ICollection<DeviceParameter> DeviceParameters { get; set; }

		//public virtual ICollection<Position> Positions { get; set; }

		public virtual ICollection<DevicePosition> Positions { get; set; }

		public virtual ICollection<Task> Tasks { get; set; }
	}
}
