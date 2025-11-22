using Microsoft.AspNetCore.Builder;
namespace NorthWind.Sales.Bacakend.IoC;

// Esta clase permite registrar todos los endpoints del proyecto NorthWind.Sales.Backend
public static class EndPointsContainer 
{
    public static WebApplication MapNorthWindSalesEndPoints(this WebApplication app)
    {
        //Registrar los endpoints "GET" del controlador para que sea visible fuera del proyecto
        //y se pueda consumir por un cliente HTTP

        //GET,SET,PUT,DELETE, POST, PATCH
        app.UseCreateOrderController();
        return app;
    }
}
