
using Northwind.Sales.Entities.Dtos.CreateOrder;
//using NorthWind.Sales.Backend.BusinessObjects.POCOEntities;
//using NorthWind.Sales.Backend.BusinessObjects.ValueObjects;
using System.Xml.Serialization;

namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates;
/// <summary>
/// Un agregado es un conjunto de entidades y objetos de valor que están relacionados y se tratan como una unidad.
/// Por ejemplo, Una orden con el detalle
/// </summary>
public class OrderAggregate : Order
{
    // Encabezado de la orden 
    // public Order Order { get; set;

    //Un auxiliar para el Detalle de la orden
    readonly List<OrderDetail> orderDetailsFiedl = [];

    //Detalle de la orden
    public IReadOnlyCollection<OrderDetail> OrderDetails => orderDetailsFiedl;

    //Si en la orden se especifica un producto que ya existe en el detalle, se debe actualizar la cantidad registrada de ese producto 
    //con el musmo identificador
    public void AddDetail(int productId, decimal unitPrice, short quantity)
    {
        var ExistingOrderDetail = orderDetailsFiedl.FirstOrDefault(o => o.PoductId == productId);
        if (ExistingOrderDetail != default) 
        {
            quantity += ExistingOrderDetail.Quantity;
            orderDetailsFiedl.Remove(ExistingOrderDetail);
        }
        orderDetailsFiedl.Add(new OrderDetail(productId, unitPrice, quantity));
    }
    public static OrderAggregate From(CreateOrderDto orderDto) 
    {
        OrderAggregate orderAggregate = new OrderAggregate 
        {
            CustomerId = orderDto.CustomerId,
            ShipAddress = orderDto.ShipAddress,
            ShipCity = orderDto.ShipCity,
            ShipCountry = orderDto.ShipCountry,
            ShipPostalCode = orderDto.ShipPostalCode,
        };

        foreach (var item in orderDto.OrderDetails)
        {
            //Si en la orden se especifica un producto que ya existe en el detalle, se debe actualizar la cantidad registrada de ese producto
            //Solo se agregara un producto con ese identificador y la cantidad se sumara a la cantidad del mismo producto
            orderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
        }
        return orderAggregate;
    }
}
