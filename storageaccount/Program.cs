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

            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=mmpractice1;AccountKey=s2gXRDVWzXqzW4DwbvTFewKWqlhfP+Cd/6ttZC+CppWDjPDZE0nln2YD66KFd4X24h8zj8NHBjDFatkseU0Tgg==;EndpointSuffix=core.windows.net");


            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("images");

            container.CreateIfNotExists(Microsoft.WindowsAzure.Storage.Blob.BlobContainerPublicAccessType.Blob);

            //var blockBlob = container.GetBlockBlobReference("Bay in Alameda 2009 - 2.png");

            //var blockBlobCopy = container.GetBlockBlobReference("Bay in Alameda 2009 - 3.png");

            //var cb = new AsyncCallback(x => Console.WriteLine("blob copy completed."));

            //blockBlobCopy.BeginStartCopy(blockBlob.Uri, cb, null);

            //using (var fileStream = System.IO.File.OpenWrite(@"/users/sunnymohan/Desktop/fromazure/Bay in Alameda 2009 - 2.png"))
            //{
            //    blockBlob.DownloadToStream(fileStream);
            //}

            //var blobs = container.ListBlobs();
            //foreach(var i in blobs)
            //{
            //    Console.WriteLine(i.Uri);
            //}




            Console.ReadKey();
        }
    }
}