using System;
namespace NMolecules.Architecture.Layered
{
    /// <summary>
    /// Identifies the {@link ApplicationLayer} in a layered architecture. The application layer is coordinating the
    /// execution of business flows without containing business rules, but by utilizing the <see cref="DomainLayerAttribute"/>. It also
    /// coordinates flows spanning other systems or bounded contexts and may keep information of the progress of the
    /// execution.
    ///
    /// Therefore, the application layer is a thin layer to enable the system to execute business flows.
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
    public class ApplicationLayerAttribute : Attribute
    {
    }
}
