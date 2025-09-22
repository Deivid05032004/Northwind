

namespace NorthWind.Sales.Backend.UseCase;

/// <summary>
/// El codigo de la clase "CreateOrderInteractor" recibe los servicios (Clases, interfaces) mediante
/// inyeccion de dependencias a traves del constructor.
/// </summary>
/// <param name="ouputPort"></param>
/// <param name="repository"></param>
internal class CreateOrderInteractor(ICreateOrderOuputPort ouputPort, ICommandsRepository repository) : ICreateOrderInputPort
{
    public async Task Handle(CreateOrderDto orderDto)
    {
        //Transformar de Dto a Aggregate

        //Poermite create un objeto de tipo: OrderAggregaten a partir de los datos de entrada 
        //que recibe como parametro en Dto (CreateOrderDto)
        OrderAggregate Order = OrderAggregate.From(orderDto);

        //Cerar la orden
        //ICommandsRepository

        await repository.CreateOrder(Order);

        //Unit of Work
        //ICreateOrderOuputPort
        //Realizar la persistencia de los datos 
        await repository.SaveChanges();

        //Regresar el identificador de la orden creada al outputPort (Presenter)
        //Regrear el id de la order por medio de la invocacion del metodo Handle dek outputPort
        await ouputPort.Handle(Order);
    }
}
