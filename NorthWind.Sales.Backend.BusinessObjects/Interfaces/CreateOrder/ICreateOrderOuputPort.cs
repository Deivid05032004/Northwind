

//using NorthWind.Sales.Backend.BusinessObjects.Aggregates;

namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder;
/// <summary>
/// El OutputPort del caso de uso (CreateOrder) es una abstraccion (interfaz) que permite al interactor
/// devolver el resultado de la operacion del caso de uso (CreateOrder) a un elemento (objeto) de la capa externa (Presenter).
/// En termino de POO, el OutputPort puede ser definido usando una interfaz (interface) o una clase abstracta (abstract class).
/// y que el Presenter debe/tiene implementar y el interactor debe/tiene que utilizar
/// El inputPort que se define a continuacion recibe una instancia de la orden que se haya creado.
/// La funcion del presenter es convertir los datos del fomaaro mas conveniente para los 
/// "Casos de uso y entidades", y tambien convierte al fortmato mas conveniente para algun
/// agente externo como: la base de datos, la interfaz de usuario, un servicio web, etc.
/// Para el ejemplo (CrearOrder) el Presenter simplemente va a devolver el identificador de la orden creada.

/// </summary>
public interface ICreateOrderOuputPort
{
    //Retorna el identificador de la orden creada que lo utliza el presenter (controller).
    int OrderId { get; }
    Task Handle(OrderAggregate orderAggregate);   
}
