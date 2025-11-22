

namespace NorthWind.Sales.Backend.DataContext.EFCore;
//namespace Micrisift.Extensions.DependencyInjection;
public static class DependencyContainer
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, Action<DBOptions> configureDBOptions)
        {
            services.Configure(configureDBOptions);

            services.AddScoped<INorthWindSalesCommandDataContext, NorthWindSalesCommandsDataContext> ();

            return services;
        }
    }

