# 02-base-patterns: Upgrade base design pattern projects

## Objective
Upgrade the design-pattern projects in the solution to target .NET 10 and keep their builds warning-free.

## Scope Inventory
- **Projects affected**: Builder, Visitor, Memento, Mediator, FlyWeight, ChainOfResponsibility, State, Iterator, Composite, TemplateMethod, Bridge, Proxy, Facade, Adapter, Command, Singleton, AbstractFactory.
- **Current state**: These projects are SDK-style already; most still target `netcoreapp3.0` or `netcoreapp3.1`. `DesignPatterns.AbstractFactory` is already on `net10.0` and should be verified rather than changed.
- **Distinct concerns**: target framework updates, solution hygiene, and build validation. No package migration work is currently expected in this task.
- **Repo hygiene request**: add a root `.gitignore` entry for `.github/upgrades/` so generated upgrade artifacts stay out of future commits.

## Research Findings
- The base-pattern projects are topologically independent enough to upgrade in grouped batches.
- The solution already contains a `.github/upgrades/` workflow folder, so the new `.gitignore` entry should be added at the repo root.
- The upgrade is primarily a TFM replacement task; the SDK-style project files already have a modern format, so the edits should be minimal.

**Done when**: The affected projects target `net10.0`, the relevant builds succeed warning-free, and the root `.gitignore` contains the requested `.github/upgrades/` ignore entry.
