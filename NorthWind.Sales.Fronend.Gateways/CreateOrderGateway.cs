

using Northwind.Sales.Entities.Dtos.CreateOrder;
using Northwind.Sales.Entities.Dtos.ValueObjects;
using Nortwhind.Sales.Fronend.Business.Objects.Interfaces;
using System.Net.Http.Json;

namespace NorthWind.Sales.Fronend.Gateways;

public class CreateOrderGateway(HttpClient client) : ICreateOrderGateway
{
    public async Task<int> CreateOrderAsync(CreateOrderDto order)
    {
        int orderId = 0;
        var Responde = await client.PostAsJsonAsync(EndPoints.CreateOrder, order );

        if (Responde.IsSuccessStatusCode)
        {
            orderId = await Responde.Content.ReadFromJsonAsync<int>();
        }
        return orderId;
    }
}
