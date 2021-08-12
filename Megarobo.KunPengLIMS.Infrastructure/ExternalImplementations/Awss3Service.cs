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
        private string _awsAccessKey;
        private string _awsSecretKey;
        private string _bucketName;
        private string _serviceUrl;
        private Amazon.RegionEndpoint _region;

        public Awss3Service(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string for AWS S3");
            }
            try
            {
                var pairs = connectionString.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var dic = new Dictionary<string, string>();
                foreach (var pair in pairs)
                {
                    var kv = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    dic.Add(kv[0], kv[1]);
                }
                _awsAccessKey = dic["AWSAccessKeyId"];
                _awsSecretKey = dic["AWSSecretAccessKey"];
                _bucketName = dic["BucketName"];
                _serviceUrl = dic["ServiceURL"];
                var reg = dic["RegionEndpoint"];
                if(reg=="cnnorth1")
                {
                    _region = Amazon.RegionEndpoint.CNNorth1;
                }
                else if(reg=="cnnorthwest1")
                {
                    _region = Amazon.RegionEndpoint.CNNorthWest1;
                }
                else
                {
                    _region = Amazon.RegionEndpoint.CNNorthWest1;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("The correct Connection String for AWS S3 is like: AWSAccessKeyId=AKIAR2BBIFEVM7TJF4WP;AWSSecretAccessKey=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;BucketName=ls-lims-service-bucket-dev;ServiceURL=https://ls-lims-service-bucket-dev.s3.cn-northwest-1.amazonaws.com.cn;RegionEndpoint=cnnorthwest1;");
            }
        }

        public async Task<S3FileObject> S3Upload(string filename, Stream content)
        {
            try
            {
                var config = new AmazonS3Config()
                {
                    ServiceURL = _serviceUrl,
                    RegionEndpoint = _region
                };
                using (var client = new AmazonS3Client(_awsAccessKey, _awsSecretKey, config))
                {
                    var request = new PutObjectRequest()
                    {
                        BucketName = _bucketName,
                        CannedACL = S3CannedACL.PublicRead,
                        Key = filename,
                        InputStream = content
                    };
                    var response = await client.PutObjectAsync(request);
                    return new S3FileObject()
                    {
                        ETag = response.ETag,
                        Url = _serviceUrl + "/" + filename,
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
                ServiceURL = _serviceUrl,
                RegionEndpoint = _region
            };
            using (var client = new AmazonS3Client(_awsAccessKey, _awsSecretKey, config))
            {
                try
                {
                    var request = new GetObjectRequest()
                    {
                        BucketName = _bucketName,
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
