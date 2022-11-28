using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a Factory. Factories encapsulate the responsibility of creating complex objects in general and
    /// Aggregates in particular. Objects returned by the factory methods are guaranteed to be in valid state.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Factories</see>
    /// </summary>
    [AttributeUsage(
            AttributeTargets.Class |
            AttributeTargets.Interface)]
    public class FactoryAttribute : Attribute
    {
    }
}
