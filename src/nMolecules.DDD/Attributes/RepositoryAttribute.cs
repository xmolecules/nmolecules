using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a Repository. Repositories simulate a collection of aggregates to which aggregate instances can be
    /// added and removed. They usually also expose API to select a subset of aggregates matching certain criteria. Access to
    /// projections of an aggregate might be provided as well but also via a dedicated separate abstraction.
    /// 
    /// Implementations use a dedicated persistence mechanism appropriate to the data structure and query requirements at
    /// hand. However, they should make sure that no persistence mechanism specific APIs leak into client code.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Repositories</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface)]
    public class RepositoryAttribute : Attribute
    {
    }
}
