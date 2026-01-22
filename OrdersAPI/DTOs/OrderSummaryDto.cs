namespace OrdersAPI.DTOs
{
    public record OrderSummaryDto
    (
        int Orderid,
        string CustomerName,
        string Status,
        Decimal TotalCost
        
    );
}
