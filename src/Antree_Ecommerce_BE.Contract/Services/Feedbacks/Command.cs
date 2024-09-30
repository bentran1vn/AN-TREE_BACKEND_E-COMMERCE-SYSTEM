using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.Feedbacks;

public static class Command
{
    public record CreateFeedbackCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid UserId { get; set; }
        public Guid OrderDetailId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public IFormFileCollection? FeedbackImages { get; set; }
    }
}