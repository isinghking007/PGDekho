using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using PGDekho.com.Logic;

namespace PGDekho.com.ServiceFolder
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary cloudinary;
        public PhotoService(IConfiguration config)
        {
            Account account = new Account(

                config.GetSection("CloudinarySetting:CloudName").Value,
                config.GetSection("CloudinarySetting:ApiKey").Value,
                config.GetSection("CloudinarySetting:ApiSecret").Value
            );

            cloudinary = new Cloudinary(account);
        }
        public async Task<ImageUploadResult> UploadPhotoAsync(IFormFile photo)
        {
            var uploadResult = new ImageUploadResult();
            if (photo.Length > 0)
            {
                using var stream = photo.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(photo.FileName, stream),
                    Transformation = new Transformation()
                        .Height(500).Width(800)
                };
                uploadResult = await cloudinary.UploadAsync(uploadParams);
            }
            return uploadResult;
        }


    }
}
