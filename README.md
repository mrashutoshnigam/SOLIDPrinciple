# Design Techniques Samples

This repository contains a collection of .NET sample applications that demonstrate software-design concepts such as SOLID principles, DRY (Don't Repeat Yourself), and common design patterns.

## What is included

- SOLID principle examples:
  - Single Responsibility
  - Open/Closed
  - Liskov Substitution
  - Dependency Inversion
  - Interface Segregation
- DRY-focused examples:
  - A reusable class library and a WinForms sample
- Design pattern examples:
  - Factory Method, Strategy, Observer, Decorator, Abstract Factory, Singleton, Command, Adapter, Facade, Proxy, Bridge, Template Method, Composite, Iterator, State, Chain of Responsibility, Flyweight, Mediator, Memento, Visitor, and Builder

## Repository layout

- `SOLIDPrinciple.*` folders contain console projects that demonstrate the SOLID principles.
- `DRY.Library`, `DRY.WinForms`, and `DRY.TestProject` contain DRY-focused code and tests.
- `DesignPatterns.*` folders and `FactoryMethod/` contain individual design-pattern samples.

## Prerequisites

- .NET SDK 3.1 or later for the console-based projects
- Windows for the WinForms sample, because it targets .NET Framework 4.7.2 and uses Windows Forms
- Visual Studio 2019/2022 or VS Code with C# support is recommended

## Build the solution

Run the following command from the repository root:

```bash
dotnet build DesignTechniques.sln
```

## Run a sample project

Most of the sample projects are console apps and can be run with `dotnet run`.
For example:

```bash
dotnet run --project SOLIDPrinciple.SingleResponsibility/SOLIDPrinciple.SingleResponsibility.csproj
```

You can replace the project path with any other console sample project in the repository.

## Notes

These projects are educational samples rather than production-ready applications. They are intended to show how to structure code and apply common design principles in practice.
