using Microsoft.AspNetCore.Http;
namespace Antree_Ecommerce_BE.Application.Abstractions;

public interface IMediaService
{
     Task<string> UploadImageAsync(IFormFile file);
}