using System;
namespace NMolecules.Architecture.Layered
{
    /// <summary>
    /// Identifies the DomainLayer in a layered architecture.The domain layer is "the heart of business software".
    /// It's responsible for representing business concepts including the domain model and the business rules and manages the
    /// business state.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Layered Architecture</see>
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Assembly |
        AttributeTargets.Module |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Struct)]
    public class DomainLayerAttribute : Attribute
    {
    }
}
