using System;
namespace NMolecules.DDD
{
    /// <summary>
    /// Identifies a domain Service. A service is a significant process or transformation in the domain that is not a
    /// natural responsibility of an entity or value object, add an operation to the model as a standalone interface declared
    /// as a service. Define a service contract, a set of assertions about interactions with the service. (See assertions.)
    /// State these assertions in the ubiquitous language of a specific bounded context. Give the service a name, which also
    /// becomes part of the ubiquitous language.
    ///
    /// <see href="https://domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf">Domain-Driven Design
    ///      Reference (Evans) - Services</see>
    /// </summary>
    [AttributeUsage(
            AttributeTargets.Class |
            AttributeTargets.Interface)]
    public class ServiceAttribute : Attribute
    {
    }
}
