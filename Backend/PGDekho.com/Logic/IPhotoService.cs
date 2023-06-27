using CloudinaryDotNet.Actions;

namespace PGDekho.com.Logic
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> UploadPhotoAsync(IFormFile photo);
    }
}
