using System;

namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies an aggregate root, i.e. the root entity of an aggregate.An aggregate forms a cluster of consistent rules
    /// usually formed around a set of entities by defining invariants based on the properties of the aggregate that have to
    /// be met before and after operations on it. Aggregates usually refer to other aggregates by their identifier.
    /// References to aggregate internals should be avoided and at least not considered strongly consistent (i.e.a reference
    /// held could possibly have been gone or become invalid at any point in time). They also act as scope of consistency,
    /// i.e.changes on a single aggregate are expected to be strongly consistent while changes across multiple ones should
    /// only expect eventual consistency.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Aggregates</see>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    [Entity]
    public class AggregateRootAttribute : EntityAttribute
    {
    }
}
