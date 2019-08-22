namespace CreApps.Heimdall.Models
{
    /// <summary>
    /// Interface for all the entities
    /// </summary>
    /// <typeparam name="TId">Data Type</typeparam>
    public interface IEntityWithTypedId<TId>
    {
        /// <summary>
        /// property that identifies the class that will implement this interface 
        /// </summary>
        TId Id { get; }
    }
}
