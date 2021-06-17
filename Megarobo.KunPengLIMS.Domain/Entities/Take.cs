using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
	/// <summary>
	/// Take
	/// </summary>
	/// ��Project���һ
	/// ��Task��Զ�
	public class Take:Entity
	{
		/// <summary>
		/// Take���
		/// </summary>
		public int TakeCode { get; set; }

		/// <summary>
		/// ״̬��������,��ֹ
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// ���������
		/// </summary>
		public Guid CurrentTaskID { get; set; }

		/// <summary>
		/// �������Ŀ
		/// </summary>
		public Guid ProjectID { get; set; }

		//[ForeignKey("CurrentTaskID")]
		//public Task CurrentTask { get; set; }

		/// <summary>
		/// ��ɵ������б�
		/// </summary>
		[NotMapped]
		public List<Task> FinishedTasks { get; set; }

		/// <summary>
		/// ǰ�������б�
		/// </summary>
		[NotMapped]
		public List<Task> PreviousTasks { get; set; }

		public virtual ICollection<TakeTask> Tasks { get; set; }

		[ForeignKey("ProjectID")]
		public virtual Project Project { get; set; }
	}
}