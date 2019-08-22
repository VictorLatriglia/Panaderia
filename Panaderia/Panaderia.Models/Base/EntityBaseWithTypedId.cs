using CreApps.Heimdall.Models.Base;

namespace CreApps.Heimdall.Models
{
    /// <summary>
    /// Base class for the implementation of models
    /// </summary>
    /// <typeparam name="Tid">Property that identified this Class</typeparam>
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedId<TId>
    {
        /// <summary>
        /// property that identifies the class
        /// </summary>
        public virtual TId Id { get; set; }
    }
}
