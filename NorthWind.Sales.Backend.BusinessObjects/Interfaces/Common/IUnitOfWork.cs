
namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.Common;
/// <summary>
/// El patron de software permite:
/// 1) Confirmar los cambio (Insert, Select, update, Delete ) en la fuente 
/// de datos (Base de datos relacional,No Sql, Json, archivo, etc) lo que garantiza una transaccion,
/// sin perderdia de datos, es decir le forma atomica.
/// 2) Tambien permite resolver confilictos de concurrencia .
/// </summary>
public interface IUnitOfWork
{
    //El metodo regresa un task que permite que la implementacion pueda ser: sincronica o asincrona.
    Task SaveChanges();
}
