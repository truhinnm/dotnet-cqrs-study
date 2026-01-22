using MediatR;
using OrdersAPI.DTOs;

namespace OrdersAPI.Queries
{
    public record GetOrderSummariesQuery() : IRequest<List<OrderSummaryDto>>;
}
