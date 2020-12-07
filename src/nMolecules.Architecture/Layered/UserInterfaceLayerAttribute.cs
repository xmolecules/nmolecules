using System;
namespace NMolecules.Architecture.Layered
{
    /// <summary>
    /// Identifies the InterfaceLayer in a layered architecture.The interface layer is responsible for handling
    /// external requests either from human users or other systems.
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
    public class UserInterfaceLayerAttribute : Attribute
    {
    }
}
