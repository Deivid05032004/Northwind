
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing.Matching;
using Northwind.Sales.Entities.Dtos.CreateOrder;
using Northwind.Sales.Entities.Dtos.ValueObjects;
using NorthWind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder;

//using Microsoft.AspNetCore.Builder;
namespace Microsoft.AspNetCore.Builder;


//namespace Microsoft.AspNetCore.Builder; Permite colocar la clase de extensiones en el mismo espacio de nombres que la clase "WebApplication" para que las
//extensiones sean accesibles directamente desde los objetos de tipo "WebApplication".

//namesopace: Permite evitar el uso de la sentencia "using" en cada archivo que necesite utilizar
//las extensiones definidas en esta clase.
//              Clase: "CreateOrderController

//namespace NorthWind.Sales.Backend.Controllers.CreateOrder;

public static class CreateOrderController
{
    // La calse extiende la funcionalidad de la clase: "WebApplication" para agregar el endpoint CreateOrder de la aplicación.
    // Este metodo utiliza "Envuelve" en metodo "CreateOrder" que es el metodoque invoca 
    // al metodo "Handle" del InputPort del caso de uso (CreateOrder) y devuelve el resultado
    //Este metodo podra ser utilizado "Consumido" por un cliente remoto a traves de la API RESTful
    public static WebApplication UseCreateOrderController (this WebApplication app)
    {
        //Create Order : Helper
        //Minimal API Endpoint
        app.MapPost(EndPoints.CreateOrder, CreateOrder);
        //app.MapPost("/CreateOrder", CreateOrder);
        return app;
    }

    // Este metodo podra ser utilizado "Consumido" por un cliente remoto a traves de la API RESTful, o un backend.
    // Pero solo aquellos que tengan tecnologia compatible con ASP.NET Core.
    public static async Task<int>CreateOrder(CreateOrderDto orderDto, ICreateOrderInputPort inputPort,ICreateOrderOuputPort presenter)
    {
        await inputPort.Handle(orderDto);
        return presenter.OrderId;
    }
}
