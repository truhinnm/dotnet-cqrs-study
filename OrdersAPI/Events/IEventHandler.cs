using Microsoft.EntityFrameworkCore.Diagnostics;

namespace OrdersAPI.Events
{
    public interface IEventHandler<TEvent>
    {
        Task HandleAsync(TEvent evt);

    }
}
