using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ISpeciesAppService
    {
        Task<PagedList<SpeciesDto>> GetSpeciesByPage(SpeciesQueryParameters parameters);

        Task<bool> InsertSpecies(SpeciesCreationDto dto);

        Task<bool> UpdateSpecies(Guid speciesId, SpeciesUpdateDto dto);

        Task<bool> DeleteSpecies(DeleteMultiDto dto);
    }
}
