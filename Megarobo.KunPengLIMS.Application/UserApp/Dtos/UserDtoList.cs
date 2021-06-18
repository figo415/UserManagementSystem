using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserDtoList:DtoList<UserDto>
    {
        public UserDtoList(IEnumerable<UserDto> userDtos)
        {
            ObjectList = userDtos;
        }
    }
}
