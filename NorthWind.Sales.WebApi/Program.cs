namespace NorthWind.Sales.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            //var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();

            //Startup star  = new Startup();
            //var builder = WebApplication.CreateBuilder(args);

            WebApplication.CreateBuilder(args)
                .CreateWebApplication()
                .ConfigureWebApplication()
                .Run();
        }
    }
}
