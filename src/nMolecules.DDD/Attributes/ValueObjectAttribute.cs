using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a value object. Domain concepts that are modeled as value objects have no conceptual identity or
    /// lifecycle. Implementations should be immutable, operations on it are side-effect free.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Value Objects</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Enum |
        AttributeTargets.Struct)]
    public class ValueObjectAttribute : Attribute
    {
    }
}
