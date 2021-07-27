using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IMolecularCloningAppService
    {
        Task<PagedList<MolecularCloningDto>> GetMolecularCloningsByPage(MolecularCloningQueryParameters parameters);

        Task<bool> UpdateMolecularCloning(Guid molecularCloningId, MolecularCloningUpdateDto dto);
    }
}
