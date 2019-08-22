using System;

namespace CreApps.Heimdall.Models
{
    /// <summary>
    /// Base class for the implementation of models
    /// </summary>
    /// <typeparam name="Tid">Property that identified this Class</typeparam>
    public abstract class EntityBase<Tid> : EntityBaseWithTypedId<Tid>
    {
        /// <summary>
        /// Date of creation of the record
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Date of update of the record
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Default constructor, create a new object with CreatedOn and UpdatedOn dates using DateTime.Now
        /// </summary>
        public EntityBase()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
