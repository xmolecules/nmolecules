using System;
namespace NMolecules.Architecture.Layered
{
    /// <summary>
    /// Identifies the InfrastructureLayer in a layered architecture.The infrastructure layer supports the other
    /// layers by providing technical capabilities such as persistence or message sending.Furthermore, it may also support
    /// the other layers in their interactions by providing framework functionalities.
    ///
    /// Provided infrastructure functionality is layer specific, i.e. functionality provided for the <see cref="UserInterfaceLayerAttribute"/>
    /// (for example REST) must not be accessed by below layers.
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
    public class InfrastructureLayerAttribute : Attribute
    {
    }
}
