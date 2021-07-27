using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class PlasmidPurificationRepository: RepositoryBase<PlasmidPurification, Guid>, IPlasmidPurificationRepository
    {
        public PlasmidPurificationRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<PlasmidPurification>> GetPlasmidPurificationsByPage(PlasmidPurificationQueryParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
