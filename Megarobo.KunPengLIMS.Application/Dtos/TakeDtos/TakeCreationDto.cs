using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class TakeCreationDto
    {
        [Required(ErrorMessage = "请选择项目")]
        public Guid ProjectId { get; set; }


    }
}
