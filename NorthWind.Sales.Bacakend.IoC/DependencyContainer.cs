using Microsoft.Extensions.DependencyInjection;
using Northwind.Sales.Backend.Repositories;
using NorthWind.Sales.Backend.DataContext.EFCore;
using NorthWind.Sales.Backend.DataContext.EFCore.Options;
using NorthWind.Sales.Backend.UseCase;
using NortWind.Sales.Backend.Presenters;
namespace NorthWind.Sales.Bacakend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindServices(this IServiceCollection services, Action <DBOptions> configureDBOptions)
    {
       services.AddUseCasesServices().AddRepositories().AddDataContext(configureDBOptions).AddPresenters();
        return services;
    }
}
