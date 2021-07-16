using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class NodeCreationDto
    {
        [Required(ErrorMessage ="节点名称不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请选择节点类型")]
        public Guid NodeTypeId { get; set; }

        public List<string> InteractiveTimeList { get; set; }

        [Required(ErrorMessage ="请输入任务持续时间")]
        public string DurationValue { get; set; }

        public string DurationUnit { get; set; }

        [Required(ErrorMessage = "请输入等待执行时间")]
        public string TimeWaitToRun { get; set; }

        [DefaultValue(true)]
        public bool CanGenerateResultSample { get; set; }

        [DefaultValue(true)]
        public bool CanGenerateResultFile { get; set; }
    }
}
