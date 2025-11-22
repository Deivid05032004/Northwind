
namespace NortWind.Sales.Backend.Presenters.CreateOrder;

// La funcion del Presenter es la de convertir los datos del formato mas conveniente para la vista (requerido)
// por los casos de uso (UseCases)  y entidades (Entities), al formato mas conveniente para la vista (ViewModel)
// Por algun agete externo (Controller, UI, API) que consume el caso de uso
internal class CreateOrderPresenter : ICreateOrderOuputPort
{
    // regresar el identificador de la orden creada
    public int OrderId { get; private set; }

    public Task Handle(OrderAggregate orderAggregate)
    {
        OrderId = orderAggregate.Id;

        //tarea completa 
        return Task.CompletedTask;
    }

}
// El interactor (UseCase) invoca al OutputPort (Presenter) para devolver el resultado de la operacion, invoca al metodo Handle definido
// en la interfaz ICreateOrderOutputPort, pasando como parametro la orden creada (OrderAggregate). para enviar el resultado del caso de uso
//El presenter en este caso Unicamente almacenara el valor recibido par que depues sea obtenido por el controlador (Controller) o cualquier otro agente externo que consuma el caso de uso
//En este caso de uso especial "No se requiere" de alguna transformacion de resultado, por ejemplo
//que se convierte a un formato especifico para la vista (ViewModel) o a un formato JSON, XML, etc.
