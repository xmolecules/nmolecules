# nMolecules – Architectural Abstractions for .NET

A set of libraries to help developers work with architectural concepts in .NET.
Member of the xMolecules family.
Goals:

* Express that a piece of code (namespace, class, method...) implements an architectural concept.
* Make it easy for the human reader to determine what kind of architectural concepts a given piece of code is.
* Allow tool integration (to do interesting stuff like generating persistence or static architecture analysis to check for validations of the architectural rules.)

## Expressing DDD Concepts

Example:

```csharp
using NMolecules.DDD;

[Entity]
public class BankAccount
{
    [Identity]
    public IBAN IBAN { get; }

    /* ... */
}

[ValueObject]
public readonly record struct Currency { /* ... */ }

[Repository]
public interface Accounts { /* ... */ }
```

When we take Ubiquitous Language serious, we want names (for classes, methods, etc.) that only contain words from the domain language.
That means the titles of the building blocks should not be part of the names.
So in a banking domain we don't want `BankAccountEntity`, `CurrencyVO` or even `AccountRepository` as types.
Instead, we want `BankAccount`, `Currency` and `Accounts` – like in the example above.

Still, we want to express that a given class (or other architectural element) is a special building block; i.e. uses a design pattern.
nMolecules provide a set of standard annotations for the building blocks known from DDD.

## Expressing Eventing Concepts

TODO

## Expressing Architecture

jMolecules provides annotations to mark a package as a layer (or ring):

TODO: port documentation from jMolecules.

## Installation

To use nMolecules in your project just install it from the NuGet Gallery.

<https://www.nuget.org/packages/NMolecules.DDD/>
<https://www.nuget.org/packages/NMolecules.Events/>
<https://www.nuget.org/packages/NMolecules.Architecture/>

## Release Instructions

Increment the version number in one or several .csproj files and the GitHub Actions will push a new release to NuGet.

Manual steps:

* In GitHub: Create a release that points to the automatically created tag vX.Y.Z
* In NuGet: Add Readme.
* In NuGet: unlist old versions.

When the NuGet secret gets obsolete, generate a new on. See <https://netlicensing.io/blog/2020/09/01/publish-nuget-packages-using-github-actions/>
