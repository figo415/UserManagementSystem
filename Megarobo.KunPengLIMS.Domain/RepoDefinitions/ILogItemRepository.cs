﻿using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ILogItemRepository:IRepositoryBase<LogItem>,IRepositoryBase2<LogItem,int>
    {
    }
}