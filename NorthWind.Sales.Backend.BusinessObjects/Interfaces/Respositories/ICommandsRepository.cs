
//using NorthWind.Sales.Backend.BusinessObjects.Interfaces.Common;

namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.Respositories;
/// <summary>
/// El patron "Repository" es un patron de diseño de software que se utliza con fuente de datos (Base de datos relacional, No Sql, Json, archivo, etc).
/// Este patron permite Separar la logica de negocuio de la logica de acceso/recuperacion de datos.
/// y los asigna a un modelo de entidad (EntityFramaerwok Core, ADO NET, Dapper)
/// Un "Repository" es una capa intermedia entre la capa de dominio (Use case) y las capas de mapeo de datos
///  y actua como un intermediadrio como una coleccion de objetos en memoria de la PC.
/// La implementacion de un "Repository" es una clase que permite ocultar la logica necesaria para almacenar 
/// (Insert, Delete, Update) o recuperar datos (Select). Por lo tanto al utilizar el 
/// patron "Repository" a la ´pliacacion no le importa que tipo de ORM de utilizo ya que todo lo
/// relacionado con el uso de un ORM se maneja dentro de la capa de "Repository".
/// Esto permite tender una separacion mas limpia de responsabilidades y hace que el codigo sea mas facil de mantener y probar.
/// </summary>
public interface ICommandsRepository : IUnitOfWork
{
    Task CreateOrder(OrderAggregate order);
    //Task DeletetOrder(int order);
    //Task UpdatetOrder(OrderAggregate order);
    

}
