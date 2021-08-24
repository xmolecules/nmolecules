using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Declares a field of a class to constitute the identity of the corresponding class. Primarily used in
    /// <code>AggregateRoot</code> and <code>Entity</code> types.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Entities</see>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class IdentityAttribute : Attribute
    {
    }
}
