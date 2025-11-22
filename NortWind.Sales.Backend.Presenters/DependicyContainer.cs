

namespace NortWind.Sales.Backend.Presenters;
//Agregar el contenedor de dependencias para los Presenters
// Inversion de dependencias /Inyecciones de dependencias
public static class DependicyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<ICreateOrderOuputPort, CreateOrderPresenter>();
        return services;
    }
}
