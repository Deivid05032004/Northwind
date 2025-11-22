namespace NorthWind.Sales.WebApi;

using NorthWind.Sales.Bacakend.IoC;
using NorthWind.Sales.Backend.DataContext.EFCore.Options;
using Swashbuckle.AspNetCore.Swagger;

// Clase auxuliar para configruar los servicios de la aplicacion
public static class Startup
{
    public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
    {
        //Configurar el componente que permite exporar la Web API en el navegador, usado Swagger
        builder.Services.AddEndpointsApiExplorer();

        // Agreagr el componente que construye los objetos para documentar los endponts de Swagger
        // con la funcionalidad de ApiExplorer
        // Genra el documento Swagger a partir de los endpoints definidos en la Web API desde el navegador

        builder.Services.AddSwaggerGen();


        //Registrar los servicios de la aplicacion
        builder.Services.AddNorthWindServices(dboptions => builder.Configuration.GetSection(DBOptions.SectionaKey).Bind(dboptions));

        // Agregar el spoport para CORS para que el cliente pueda consumir la Web API desde otro dominio
        // (como por ejemplo: React, vue, Angular, Svelte, Solid, Next, Blazor, Etc) puedan consumir la Web API
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(config =>
            {
                config.AllowAnyMethod();
                config.AllowAnyHeader();
                config.AllowAnyOrigin();

            });
        });

        return builder.Build();
    }
    public static WebApplication ConfigureWebApplication(this WebApplication app)
    {
        // Habilitar el middleware de Swagger para generar el documento Swagger en tiempo de ejecucion

        // Solo si esta en modo de desarrollo
        if (app.Environment.IsDevelopment()) 
        {
            // Habilitar el middleware de Swagger para generar el documento Swagger en tiempo de ejecucion
            app.UseSwagger();
            // Habilitar el middleware de Swagger UI para exponer la interfaz de usuario de Swagger en el navegador
            app.UseSwaggerUI();
        }

        // Registrar el middleware de CORS en la tuberia de procesamiento de solicitudes HTTP
        app.MapNorthWindSalesEndPoints();

        // habilitar el middleware de CORS en la tuberia de procesamiento de solicitudes HTTP
        app.UseCors();

        return app;
    }
}
