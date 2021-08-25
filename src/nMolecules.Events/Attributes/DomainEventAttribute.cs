using System;
namespace NMolecules.Events
{
    /// <summary>
    /// A domain event is a full-fledged part of the domain model, a representation of something that happened in the domain.
    /// It allows making the events that the domain experts want to track or be notified of explicit, or which are associated
    /// with state change in the other model objects.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Domain Events</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Event)]
    public class DomainEventAttribute : Attribute
    {
    }
}
