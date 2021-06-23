using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DictItemUpdateDto
    {
        [Required(ErrorMessage = "字典名称不能为空")]
        public string KeyName { get; set; }

        [Required(ErrorMessage = "字典类型不能为空")]
        public string Type { get; set; }
    }
}
