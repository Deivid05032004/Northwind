
namespace NorthWind.Sales.Backend.BusinessObjects.ValueObjects;

/// <summary>
/// Los value Obects :Tiene 2 caracteristicas principales
/// - No tienen identidad propia
/// -Son inmutables
/// </summary>
/// <param name="productId"></param>
/// <param name="unitPrice"></param>
/// <param name="quantity"></param>
public class OrderDetail (int productId, decimal unitPrice, short quantity)
{
    //public int ProductId { get; } = productId;
    //public decimal UnitPrice { get; } = unitPrice;
    //public short Quantity { get; } = quantity;
    public int PoductId => productId;
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;



}
