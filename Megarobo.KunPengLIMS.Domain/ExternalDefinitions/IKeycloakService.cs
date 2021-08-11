using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Domain.ExternalDefinitions
{
    public interface IKeycloakService
    {
        Task<bool> CreateUser(Guid id, string username, string email, bool isActive);

        Task<bool> UpdateUser(Guid userid, string username, string email, bool isActive);

        Task<bool> EnableUser(Guid userid, bool isActive);

        Task<bool> ChangePassword(Guid userid, string password);

        UserInfoResponse CheckToken(string token);

        Task<bool> DeleteUser(Guid userid);
    }
}
