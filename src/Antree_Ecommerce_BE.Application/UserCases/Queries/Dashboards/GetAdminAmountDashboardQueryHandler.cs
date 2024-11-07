using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Dashboards;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Dashboards;

public class GetAdminAmountDashboardQueryHandler : IQueryHandler<Query.GetAdminAmountDashboardQuery, Response.GetAdminAmountDashboard>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IRepositoryBase<Transaction, Guid> _transactionRepository;
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IRepositoryBase<Domain.Entities.Vendor, Guid> _vendorRepository;

    public GetAdminAmountDashboardQueryHandler(IRepositoryBase<Order, Guid> orderRepository, IRepositoryBase<User, Guid> userRepository, IRepositoryBase<Transaction, Guid> transactionRepository, IRepositoryBase<Domain.Entities.Vendor, Guid> vendorRepository)
    {
        _orderRepository = orderRepository;
        _userRepository = userRepository;
        _transactionRepository = transactionRepository;
        _vendorRepository = vendorRepository;
    }

    public async Task<Result<Response.GetAdminAmountDashboard>> Handle(Query.GetAdminAmountDashboardQuery request, CancellationToken cancellationToken)
    {
        var vendorCount = await _vendorRepository.FindAll(x => x.Status.Equals(0) && !x.IsDeleted).CountAsync(cancellationToken);
        var userCount = await _userRepository.FindAll(x => x.Role.Equals(0) && !x.IsDeleted).CountAsync(cancellationToken);
        var tranQuery =  _transactionRepository.FindAll(x => x.Status.Equals(1) && !x.IsDeleted);
        var tranCount = await tranQuery.CountAsync(cancellationToken);
        var orderCount = await _orderRepository.FindAll(x => x.Status.Equals(1) && !x.IsDeleted).SumAsync(x => x.Total, cancellationToken: cancellationToken);
        var freeSub = await _userRepository.FindAll(
                x => x.Role.Equals(0)
                     && !x.IsDeleted
                     && (!x.TransactionList.Any(transaction => transaction.Status.Equals(1) && !transaction.IsDeleted) || x.TransactionList == null))
            .CountAsync(cancellationToken);
        var existSub = await _userRepository.FindAll(
                x => x.Role.Equals(0)
                     && !x.IsDeleted
                     && x.TransactionList.Any(transaction => transaction.Status.Equals(1) && !transaction.IsDeleted))
            .CountAsync(cancellationToken);

        // var result = await Task.WhenAll(vendorCount, userCount, tranCount, orderCount);
        orderCount += await tranQuery.SumAsync(x => x.Total, cancellationToken);

        return Result.Success(
            new Response.GetAdminAmountDashboard(orderCount, tranCount, vendorCount,
                userCount, freeSub, existSub));
    }
}