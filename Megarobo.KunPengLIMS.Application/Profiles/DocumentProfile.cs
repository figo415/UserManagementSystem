using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class DocumentProfile:Profile
    {
        public DocumentProfile()
        {
            CreateMap<S3FileObject, DocumentDto>();
        }
    }
}
