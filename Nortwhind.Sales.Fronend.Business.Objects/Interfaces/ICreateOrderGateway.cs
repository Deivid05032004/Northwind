
//using Northwind.Sales.Entities.Dtos.CreateOrder;

namespace Nortwhind.Sales.Fronend.Business.Objects.Interfaces;

// Esta interface permitira implementar una clase para encapsular el codigo cliente que
// consuma la Web API para crear LA ORDERN DESDE bLazor
public interface ICreateOrderGateway
{
    Task<int> CreateOrderAsync(CreateOrderDto order);
}
