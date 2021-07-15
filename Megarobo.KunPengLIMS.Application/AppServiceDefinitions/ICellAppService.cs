using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface ICellAppService
    {
        Task<PagedList<CellDto>> GetCellsByPage(CellQueryParameters parameters);

        Task<bool> InsertCell(CellCreationDto dto);

        Task<bool> UpdateCell(Guid cellId, CellUpdateDto dto);

        Task<bool> DeleteCells(DeleteMultiDto dto);
    }
}
