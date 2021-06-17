using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class AuthRequestDto
    {
        [Required(ErrorMessage = "用户名不能为空。")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空。")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
