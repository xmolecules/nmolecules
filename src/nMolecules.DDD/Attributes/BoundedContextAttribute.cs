using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a bounded context. A description of a boundary (typically a subsystem, or the work of a particular team)
    /// within which a particular model is defined and applicable.A bounded context has an architectural style and contains
    /// domain logic and technical logic.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Bounded Contexts</see>
    /// </summary>
    [AttributeUsage(
            AttributeTargets.Assembly |
            AttributeTargets.Module)]
    public class BoundedContextAttribute : Attribute
    {
    }
}
