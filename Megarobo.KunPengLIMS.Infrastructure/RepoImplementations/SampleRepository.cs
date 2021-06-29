using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class SampleRepository : RepositoryBase<Sample, Guid>, ISampleRepository
    {
        public SampleRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
