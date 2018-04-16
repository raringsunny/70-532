using System;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;

namespace storageaccount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var storageAccount = CloudStorageAccount.Parse(
                //CloudConfigurationManager.GetSetting("StorageConnection"));

            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=mmpractice1;AccountKey=ImLCJKvB/XavjIIRIAvf48bDjcYqggUSxFx4AwWrLgKw2DNmxuZwLEcu6ONX3Fdb/BEoBZvydRlBkMwgYgaz4Q==;EndpointSuffix=core.windows.net");


            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("images");

            container.CreateIfNotExists(Microsoft.WindowsAzure.Storage.Blob.BlobContainerPublicAccessType.Blob);

            Console.ReadKey();
        }
    }
}