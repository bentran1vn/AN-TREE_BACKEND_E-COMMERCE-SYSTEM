using System.ComponentModel.DataAnnotations;

namespace Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Options;

public class JwtOption
{
    [Required]public string Issuer { get; set; }
    [Required]public string Audience { get; set; }
    [Required]public string SecretKey { get; set; }
    [Required]public int ExpireMin { get; set; }
}