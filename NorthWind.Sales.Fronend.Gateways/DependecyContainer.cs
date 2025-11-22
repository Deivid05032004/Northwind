
using Microsoft.Extensions.DependencyInjection;
using Nortwhind.Sales.Fronend.Business.Objects.Interfaces;
using System.Net;

namespace NorthWind.Sales.Fronend.Gateways;

public static class DependecyContainer
{
    public static IServiceCollection AddWebApiGateWays(this IServiceCollection services, Action<HttpClient> configureHttpClient)
    {
        services.AddHttpClient<ICreateOrderGateway,CreateOrderGateway> (configureHttpClient);
        return services;
    }
}
