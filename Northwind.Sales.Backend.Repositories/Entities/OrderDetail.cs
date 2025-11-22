

namespace Northwind.Sales.Backend.Repositories.Entities;
//Entidad-modelo de datos que representa el detalle de la orden
public class OrderDetail
{
    public int OrderId { get; set; }
    // La prioridad Order Permite establecer la relacion entre una orden y sus detalles
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public decimal unitPrice { get; set; }
    public short quantity { get; set; }



    //------------------------------------------

}
