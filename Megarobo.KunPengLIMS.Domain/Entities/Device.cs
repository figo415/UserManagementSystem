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
	/// ��Positionһ�Զ�
	/// ��Taskһ�Զ�
	public class Device:Entity
	{
		public string Name { get; set; }

		/// <summary>
		/// ������,PCR,��Һ����վ,����
		/// </summary>
		public string SubClass { get; set; }

		public virtual ICollection<NodeDevice> Nodes { get; set; }

		public virtual ICollection<DeviceParameter> DeviceParameters { get; set; }

		public virtual ICollection<Position> Positions { get; set; }

		public virtual ICollection<Task> Tasks { get; set; }
	}
}
