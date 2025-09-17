
//using Northwind.Sales.Entities.Dtos.CreateOrder;

namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder;
/// <summary>
/// Los puertos (InputPort, OutPort) son abstracciones (interfaces) que permiten
/// al Interactor del caso de uso (CreateOrder) Recibir los datos de entrada y proporcionar
/// el resultado de salida del caso de uso (CreateOrder).
/// 
/// El iNPUT pORT del caso de uso (CreateOrder) es una abstraccion (interfaz) que permiter al interactor
/// recibir los datos necesarios para resolver el caso de uso (CreateOrder) .estos datos son proporcionados
/// por algun elemento (objeto) de la capa externa (controller).
/// En terminos de POO, el InputPort puede ser definido usando una interfaz (interface) o una clase abstracta (abstract class).
/// que el interactor debe/tiene que implementar.  y el (controller) debe/tiene que utilizar
/// 
/// </summary>
public interface ICreateOrderInputPort
{

    Task Handle(CreateOrderDto orderDto);
}
