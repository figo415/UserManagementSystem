using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Domain.ExternalDefinitions
{
    public interface IAwss3Service
    {
        Task<S3FileObject> S3Upload(string filename, Stream content);

        Task<byte[]> S3Download(string keyname);
    }
}
