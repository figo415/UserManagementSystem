using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// �豸ʹ�ò���
	/// </summary>
	/// ��Device���һ
	/// ��ProtocolStepһ�Զ�
	public class DeviceParameter:Entity
	{
		public string Note{ get; set; }

		/// <summary>
		/// Ƕ��ֵ����ת��
		/// </summary>
		public RotationRate RotationRate;

		/// <summary>
		/// Ƕ��ֵ�����ļ�
		/// </summary>
		public File Script { get; set; }

		/// <summary>
		/// Ƕ��ֵ�����¶�
		/// </summary>
		public Temperature Temprature;

		/// <summary>
		/// Ƕ��ֵ����ʱ����
		/// </summary>
		public TimeInterval TimeInterval;

		/// <summary>
		/// ������豸
		/// </summary>
		public Guid DeviceID;

		[ForeignKey("DeviceID")]
		public Device Device { get; set; }

		public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; }
	}
}
