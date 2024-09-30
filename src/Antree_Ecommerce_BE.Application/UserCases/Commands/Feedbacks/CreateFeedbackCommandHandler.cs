using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Feedbacks;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Query = Antree_Ecommerce_BE.Contract.Services.Products.Query;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Feedbacks;

public class CreateFeedbackCommandHandler : ICommandHandler<Command.CreateFeedbackCommand>
{
    private readonly IMediaService _mediaService;
    private readonly IRepositoryBase<OrderDetailFeedback, Guid> _orderDetailFeedbackRepository;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IRepositoryBase<OrderDetailFeedbackMedia, Guid> _orderDetailFeedbackMediaRepository;
    private readonly IRepositoryBase<ProductFeedback, Guid> _productFeedbackRepository;
    private readonly ICacheService _cacheService;

    public CreateFeedbackCommandHandler(IMediaService mediaService, IRepositoryBase<OrderDetailFeedback, Guid> orderDetailFeedbackRepository, IRepositoryBase<OrderDetailFeedbackMedia, Guid> orderDetailFeedbackMediaRepository, IRepositoryBase<Order, Guid> orderRepository, IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IRepositoryBase<ProductFeedback, Guid> productFeedbackRepository, ICacheService cacheService)
    {
        _mediaService = mediaService;
        _orderDetailFeedbackRepository = orderDetailFeedbackRepository;
        _orderDetailFeedbackMediaRepository = orderDetailFeedbackMediaRepository;
        _orderDetailRepository = orderDetailRepository;
        _productFeedbackRepository = productFeedbackRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.CreateFeedbackCommand request, CancellationToken cancellationToken)
    {
        var orderDetail = await _orderDetailRepository.FindSingleAsync(
            x => x.Id == request.OrderDetailId ,
            cancellationToken,
            x => x.Order);
        
        if (orderDetail! is null)
        {
            return Result.Failure(new Error("404", "Order detail not found"));
        }
        
        if (orderDetail.Order! is null)
        {
            return Result.Failure(new Error("404", "Order not found"));
        }

        if (!orderDetail.Order.UserId.Equals(request.UserId))
        {
            return Result.Failure(new Error("403", "Forbidden: Cannot feedback on another customer's product"));
        }
        
        var orderDetailFeedback = new OrderDetailFeedback()
        {
            Id = Guid.NewGuid(),
            Content = request.Content,
            Rating = request.Rating,
        };
        
        _orderDetailFeedbackRepository.Add(orderDetailFeedback);

        orderDetail.OrderDetailFeedbackId = orderDetailFeedback.Id;

        var feedbackData = await _orderDetailRepository
            .FindAll(x => x.OrderId == orderDetail.OrderId)
            .GroupBy(x => 1)
            .Select(g => new 
            {
                TotalOrderDetails = g.Count(),
                FeedbackCount = g.Count(x => x.OrderDetailFeedbackId != null)
            })
            .FirstOrDefaultAsync(cancellationToken);

        var orderDetailsFeedbackCount = feedbackData?.FeedbackCount + 1 ?? 1;
        var totalOrderDetailsCount = feedbackData?.TotalOrderDetails ?? 0;

        if (orderDetailsFeedbackCount == totalOrderDetailsCount)
        {
            orderDetail.Order.IsFeedback = true;
        }
        
        var imageUploadTask = request.FeedbackImages?.Any() == true 
            ? Task.WhenAll(request.FeedbackImages.Select(x => _mediaService.UploadImageAsync(x)))
            : Task.FromResult(Array.Empty<string>());

        var productFeedbackTask = _productFeedbackRepository
            .FindAll(x => x.ProductId == orderDetail.ProductId)
            .ToListAsync(cancellationToken);

        await Task.WhenAll(imageUploadTask, productFeedbackTask);

        var uploadedImages = imageUploadTask.Result;
        var productFeedbacks = productFeedbackTask.Result;

        // Insert feedback images in a batch
        if (uploadedImages?.Any() == true)
        {
            var orderDetailFeedbackMedias = uploadedImages
                .Select(imageUrl => new OrderDetailFeedbackMedia
                {
                    Id = Guid.NewGuid(),
                    ImageUrl = imageUrl,
                    OrderDetailFeedbackId = orderDetailFeedback.Id
                }).ToList();

            _orderDetailFeedbackMediaRepository.AddRange(orderDetailFeedbackMedias);
        }
        
        var existingFeedback = productFeedbacks.FirstOrDefault(f => f.Rate == request.Rating);
        if (existingFeedback != null)
        {
            existingFeedback.Total += 1;
        }
        else
        {
            var productFeedback = new ProductFeedback
            {
                Id = Guid.NewGuid(),
                ProductId = orderDetail.ProductId,
                Rate = request.Rating,
                Total = 1
            };
            _productFeedbackRepository.Add(productFeedback);
        }
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success("Feedback Product Successfully !");
    }
}