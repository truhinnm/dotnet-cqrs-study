using MediatR;
using OrdersAPI.DTOs;

namespace OrdersAPI.Commands
{
    public record CreateOrderCommand(
        string FirstName, 
        string LastName, 
        string Status, 
        decimal TotalCost
    ) : IRequest<OrderDto>;
}
