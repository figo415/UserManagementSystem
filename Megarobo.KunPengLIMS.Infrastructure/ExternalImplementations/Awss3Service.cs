using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using Amazon.S3;
using Amazon.S3.Model;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations
{
    /// <summary>
    /// 指南https: docs.aws.amazon.com/sdk-for-net/latest/developer-guide/welcome.html
    /// AWS CLI: https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html
    /// </summary>
    public class Awss3Service:IAwss3Service
    {
        private readonly string awsAccessKey = "AKIAR2BBIFEVM7TJF4WP";
        private readonly string awsSecretKey = "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";
        private readonly string bucketName = "ls-lims-service-bucket-dev";
        private readonly string serviceUrl = "https://ls-lims-service-bucket-dev.s3.cn-northwest-1.amazonaws.com.cn";
        private readonly Amazon.RegionEndpoint region = Amazon.RegionEndpoint.CNNorthWest1;

        public async Task<S3FileObject> S3Upload(string filename, Stream content)
        {
            try
            {
                var config = new AmazonS3Config()
                {
                    ServiceURL = serviceUrl,
                    RegionEndpoint = region
                };
                using (var client = new AmazonS3Client(awsAccessKey, awsSecretKey, config))
                {
                    var request = new PutObjectRequest()
                    {
                        BucketName = bucketName,
                        CannedACL = S3CannedACL.PublicRead,
                        Key = filename,
                        InputStream = content
                    };
                    var response = await client.PutObjectAsync(request);
                    return new S3FileObject()
                    {
                        ETag = response.ETag,
                        Url = serviceUrl + "/" + filename,
                    };
                }
            }
            catch(Exception ex)
            {
                return new S3FileObject() { ExceptionMessage = ex.Message };
            }
        }

        public async Task<byte[]> S3Download(string keyname)
        {
            var config= new AmazonS3Config()
            {
                ServiceURL = serviceUrl,
                RegionEndpoint = region
            };
            using (var client = new AmazonS3Client(awsAccessKey, awsSecretKey, config))
            {
                try
                {
                    var request = new GetObjectRequest()
                    {
                        BucketName = bucketName,
                        Key = keyname
                    };
                    var response = await client.GetObjectAsync(request);
                    var bytes = new byte[response.ResponseStream.Length];
                    using (response.ResponseStream)
                    {
                        response.ResponseStream.Read(bytes, 0, bytes.Length);
                    }
                    
                    return bytes;
                }
                catch(Exception ex)
                {
                    return new byte[0];
                }
            }
        }
    }
}
