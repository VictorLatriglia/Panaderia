
using CreApps.Heimdall.Models;
using Microsoft.EntityFrameworkCore;

namespace CreApps.Heimdall.DataAccess
{
    /// <summary>
    /// Repository that implements the CRUD operations
    /// </summary>
    /// <typeparam name="T">Model class where the CRUD operations will be executed</typeparam>
    /// <typeparam name="Tid">Class Identificator type</typeparam>
    public class Repository<T, TId> : RepositoryWithTypedId<T, TId>, IRepository<T, TId>
      where T : class, IEntityWithTypedId<TId>
    {
        public Repository(HeimdallDbContext context) : base(context)
        {

        }
    }
}
