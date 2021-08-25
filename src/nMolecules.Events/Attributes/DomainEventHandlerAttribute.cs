using System;
namespace NMolecules.Events
{
    /// <summary>
    /// Identifies a domain event handler, i.e. logic to process a {@link DomainEvent}.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Domain Events</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Delegate)]
    public class DomainEventHandlerAttribute : Attribute
    {
    }
}
