
//using Microsoft.Extensions.DependencyInjection;

namespace NorthWind.Sales.Backend.UseCase;
// Agregar el contenedor de dependencias (IoC)
// Inversion de dependecias/Inyeccion de dependencias
public static class DependencyContainer
{
    //Debido a que hemos creado un servicio /funcionalidad  (ICreateOrderImputPort), debemos crear
    // el codigo que permita el REGISTRO de ka implementacion en el contenedor de dependencias
    // "Microsoft.Extension.DependencyInjection". "ServiceCollestion"

    //  Una tecnica para facilitar el registro de dependencias es crear una CLASE estatica que 
    //  exponga (tenga) un metodo de EXTENCION que tambien sea estatico  de tipo IServiceCollection
    // donde se deben registrar todas las dependencias (servicios) que se requieran en la aplicacion.
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        //Inyeccion de dependencias

        //Transient: Cada vez que se solicite una instancia de la clase, se crea una nueva instancia.
        //Scoped: Se crea una unica instancia de la clase por cada solicitud HTTP.
        //Singleton: Se crea una unica instancia de la clase para toda la aplicacion.

        //  Se eenvia una interfaz : ICreateOrderInputPort
        // y el segundo parametro debe ser la clase que implementa la interfaz
        // El contenedor de dependencias:
        //             1) Regresa una instancia de la clase: CreateOrderInteractor
        //             2) Administra y gestiona el ciclo de vida de la instancia (CreateOrderInteractor)


        //Agrega el servicio
        //services.AddSingleton
        //services.AddTransient


        services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();
        return services;
    }
}
