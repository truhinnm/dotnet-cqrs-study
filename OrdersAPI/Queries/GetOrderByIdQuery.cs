using MediatR;
using OrdersAPI.DTOs;

namespace OrdersAPI.Queries
{
    public record GetOrderByIdQuery (int OrderId) : IRequest<OrderDto>;
}
