using CreApps.Heimdall.Models;

namespace CreApps.Heimdall.DataAccess
{
    /// <summary>
    /// Interface that holds the CRUD contracts
    /// </summary>
    /// <typeparam name="T">Clase Modelo en la cual se realizarán las operaciones CRUD</typeparam>
    /// <typeparam name="TId">Tipo de datos del identificador de la clase</typeparam>
    public interface IRepository<T, TId> : IRepositoryWithTypedId<T, TId> where T : IEntityWithTypedId<TId>
    {
    }
}
