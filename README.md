# nMolecules – Architectural abstractions for .NET

A set of libraries to help developers work with architectural concepts in .NET.
Member of the xMolecules family.
Goals:

* Express that a piece of code (namespace, class, method...) implements an architectural concept.
* Make it easy for the human reader to determine what kind of architectural concepts a given piece of code is.
* Allow tool integration (to do interesting stuff like generating persistence or static architecture analysis to check for validations of the architectural rules.)

## Expressing DDD concepts

Example:

```csharp
using NMolecules.DDD;

[Entity]
public class BankAccount { /* ... */ }

[ValueObject]
public class Currency { /* ... */ }

[Repository]
public class Accounts { /* ... */ }
```

When we take Ubiquitous Language serious, we want names (for classes, methods, etc.) that only contain words from the domain language.
That means the titles of the building blocks should not be part of the names.
So in a banking domain we don't want `BankAccountEntity`, `CurrencyVO` or even `AccountRepository` as types.
Instead, we want `BankAccount`, `Currency` and `Accounts` – like in the example above.

Still, we want to express that a given class (or other architectural element) is a special building block; i.e. uses a design pattern.
nMolecules provide a set of standard annotations for the building blocks known from DDD.

## Expressing architecture

jMolecules provides annotations to mark a package as a layer (or ring):

TODO: port documentation from jMolecules.

## Installation

To use nMolecules in your project just install it from the Nuget central repository.

TODO

## Release instructions

TODO