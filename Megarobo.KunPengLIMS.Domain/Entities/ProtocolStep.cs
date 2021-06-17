using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// ��Node��Զ�
	/// ��Solution���һ
	/// ��DeviceParameter���һ
	/// ��Taskһ�Զ�
	/// </summary>
	public class ProtocolStep:Entity
	{
		[Description("��������")]
		public string Description { get; set; }

		/// <summary>
		/// ������豸ʹ�ò���
		/// </summary>
		public Guid DeviceParameterID { get; set; }

		[ForeignKey("DeviceParameterID")]
		public DeviceParameter DeviceParameter { get; set; }

		public string Note { get; set; }

		/// <summary>
		/// ��Ӧ��ϵ���������Һ��ϵ
		/// </summary>
		public Guid SolutionID { get; set; }

		[ForeignKey("SoluationID")]
		public Solution Solution { get; set; }

		public Guid ParentID { get; set; }

		public virtual ICollection<NodeProtocolStep> Nodes { get; set; }

		public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// ��ProtocolStep�б�
		/// </summary>
		//public List<ProtocolStep> SubProtocols { get; set; }
	}
}