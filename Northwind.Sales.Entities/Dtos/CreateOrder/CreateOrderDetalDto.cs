namespace Northwind.Sales.Entities.Dtos.CreateOrder;

// Primaryy Constructors c# 12
public class CreateOrderDetalDto (int productId, decimal unitPrice, short quantity)
{
    public int ProductId => productId;
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;


}
