

namespace Northwind.Sales.Backend.Repositories;

public  static class DependencyIContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Interfaz: IcomandsRepository
        // Clase que implementa la interfaz: CommandsRespositiry

        services.AddScoped<ICommandsRepository, CommandsRepository>();

        //Agregar el servicio al contenedor de dependencias

        return services;
    }
}
