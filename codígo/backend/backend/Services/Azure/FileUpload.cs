using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs.Models;



namespace backend.Services.Azure
{
    
    public class FileUpload
    {
        private readonly IConfiguration _configuration;
        public FileUpload(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> UploadAsync(IFormFile anexo)
        {

            using var stream = new MemoryStream();
            await anexo.CopyToAsync(stream);
            stream.Position = 0;

            var connectionString = _configuration["Blob:ConnectionStrings"];
            var containerName = _configuration["Blob:ContainerName"];

            BlobContainerClient container = new(connectionString, containerName);
            await container.CreateIfNotExistsAsync(PublicAccessType.None);

            string uniqueFileName = await GetUniqueBlobAsync(container, anexo.FileName);
            await container.UploadBlobAsync(uniqueFileName, stream);

            Certificate certificate = new();

            string UrlAcess = certificate.AcessImgBlob(container.Uri.AbsoluteUri, uniqueFileName);
            
            return UrlAcess;
        }

        private static async Task<string> GetUniqueBlobAsync(BlobContainerClient containerClient, string fileName)
        {
            fileName = fileName.Replace(" ", "");
            string baseFileName = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName);

            string uniqueFileName = fileName;
            int index = 1;

            while(await containerClient.GetBlobClient(uniqueFileName).ExistsAsync())
            {
                uniqueFileName = $"{baseFileName}{index}{extension}";
                index++;
            }
            return uniqueFileName;
        }
    }
}
