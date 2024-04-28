using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Common
{
    /// <summary>
    /// This abstract class serves as the base class for all your domain entities. It provides common functionality related to domain events.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Each entity has a unique `Id` property, automatically generated as a GUID string.
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Unique identifier for the entity
        /// <summary>
        /// This private list stores the domain events raised by the entity. 
        /// </summary>
        private readonly List<BaseEvent> _domainEvents = new(); // Private list to store domain events
        /// <summary>
        /// This read-only property provides access to the list of domain events. 
        /// The `[NotMapped]` attribute ensures that Entity Framework Core (if used) will not try to map this property to a database column.
        /// </summary>
        [NotMapped] // Ensures EF Core doesn't try to map this property to a database column
        public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly(); // Provides read-only access to the list of domain events
        /// <summary>
        /// AddDomainEvent, RemoveDomainEvent and ClearDomainEvent: These methods allow you to manage the domain events associated with the entity. 
        /// You can add new events, remove specific events, or clear the entire list.
        /// </summary>
        /// <param name="domainEvent"></param>
        public void AddDomainEvent(BaseEvent domainEvent) => _domainEvents.Add(domainEvent); // Adds a domain event to the list
        public void RemoveDomainEvent(BaseEvent domainEvent) => _domainEvents.Remove(domainEvent);  // Removes a specific domain event
        public void ClearDomainEvent() => _domainEvents.Clear();  // Clears all domain events from the list

    }
}
