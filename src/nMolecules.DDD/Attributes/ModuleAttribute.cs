using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a DDD module.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Modules</see>
    /// </summary>
    [AttributeUsage(
            AttributeTargets.Assembly |
            AttributeTargets.Module)]
    public class ModuleAttribute : Attribute
    {
    }
}
