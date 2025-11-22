
using Northwind.Sales.Backend.Repositories.Interfaces;
using NorthWind.Sales.Backend.DataContext.EFCore.DataContexts;

namespace NorthWind.Sales.Backend.DataContext.EFCore.Services;

// Esta clase implementa el contexto de Datos lo que permite agregar una orden, los detalles de la orden y guardar los cambios
// Espeo permitira remplazar Entity Framework Core por otro ORM en el futuro si es necesario
internal class NorthWindSalesCommandsDataContext(IOptions<DBOptions> dbOptions) : NorthWindSalesContext(dbOptions), INorthWindSalesCommandDataContext
{
    public async Task AddOrderAsync(Order order) => await AddAsync(order);


    public async Task AddOrderDetailsAsync(IEnumerable<OrderDetail> orderDetails) => await AddRangeAsync(orderDetails);


    public async Task SaveChangesAsync() => await base.SaveChangesAsync();
    
}
