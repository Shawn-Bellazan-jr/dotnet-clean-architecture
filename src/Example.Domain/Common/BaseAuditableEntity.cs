using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Common
{
    /// <summary>
    ///  This class inherits from BaseEntity, which means it gains the domain event capabilities. 
    ///  Auditable entities can also raise domain events when created or modified. 
    /// </summary>
    public abstract class BaseAuditableEntity : BaseEntity // Inherits from BaseEntity for domain event capabilities
    {
        /// <summary>
        /// Each entity has a unique `Id` property, automatically generated as a GUID string.
        /// </summary>
        public DateTimeOffset Created { get; set; } // Timestamp when the entity was created
        /// <summary>
        /// This property stores information about the user who created the entity. This is often a username, user ID, or another identifier depending on your application's user management system. 
        /// </summary>
        public string? CreatedBy { get; set; } // Identifier (e.g., username) of the user who created the entity
        /// <summary>
        /// Similar to `Created`, this property tracks the date and time when the entity was last modified or updated. 
        /// </summary>
        public DateTimeOffset LastModified { get; set; } // Timestamp when the entity was last modified
        /// <summary>
        /// This property stores information about the user who last modified the entity, similar to `CreatedBy`.
        /// </summary>
        public string? LastModifiedBy { get; set; } // Identifier of the user who last modified the entity
    }
}
