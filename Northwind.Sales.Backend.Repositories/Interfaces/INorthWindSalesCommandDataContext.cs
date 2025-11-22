
namespace Northwind.Sales.Backend.Repositories.Interfaces;
//DataContext: El contexto de datos permitira  agregar añ repositorio una orden, el detalle de la orden y guardar los cambios
// utilizando el metodo SaveChangesAsync
public interface INorthWindSalesCommandDataContext
{
    // select
    // insert
    // update
    // delete

    //Inserta el encabezado de la orden
    Task AddOrderAsync(Order order);
    // Inserta los detalles de la orden
    Task AddOrderDetailsAsync(IEnumerable<Entities.OrderDetail> orderDetails);
    //Guarda los cambios realizados en el contexto de datos de forma asíncrona
    Task SaveChangesAsync();
}

