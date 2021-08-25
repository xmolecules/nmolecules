using System;
namespace NMolecules.Events
{
    /// <summary>
    /// Identifies a domain event publisher, i.e. logic to publish a {@link DomainEvent}.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Domain Events</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class DomainEventPublisherAttribute : Attribute
    {
    }
}
