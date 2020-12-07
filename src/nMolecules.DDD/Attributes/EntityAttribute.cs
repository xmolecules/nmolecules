using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies an Entity. Entities represent a thread of continuity and identity, going through a lifecycle,
    /// though their attributes may change. Means of identification may come from the outside, or it may be an arbitrary
    /// identifier created by and for the system, but it must correspond to the identity distinctions in the model. The model
    /// must define what it means to be the same thing.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Entities</see>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
    }
}
