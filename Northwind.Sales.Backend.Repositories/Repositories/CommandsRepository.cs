

namespace Northwind.Sales.Backend.Repositories.Repositories;

internal class CommandsRepository(INorthWindSalesCommandDataContext context) : ICommandsRepository
{
    public async Task CreateOrder(OrderAggregate order)
    {

        //Agreagr el encabezado de la orden
        await context.AddOrderAsync(order);

        //Agregrar el detalle de la orden (LINQ)
        await context.AddOrderDetailsAsync(order.OrderDetails.Select(d => new Entities.OrderDetail
        {
            Order = order,
            ProductId = d.ProductId,
            quantity = d.Quantity,
            unitPrice = d.UnitPrice
        }).ToArray());
    }

    //public async Task SaveChanges()
    //{
    //    await context.SaveChangesAsync();
    //}
    public async Task SaveChanges() => await context.SaveChangesAsync();
}
