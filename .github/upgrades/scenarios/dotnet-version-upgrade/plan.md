# Upgrade to .NET 10 Plan

## Overview

**Target**: All projects in DesignTechniques.sln
**Scope**: 29 projects

## Tasks

### 01-convert-sdk: Convert non-SDK style projects to SDK-style

Convert DRY.Library, DRY.TestProject, and DRY.WinForms to SDK-style format so they can support multi-targeting or directly upgrade to .NET 10.

**Done when**: The 3 projects are in SDK-style format and build successfully.

---

### 02-base-patterns: Upgrade base design pattern projects

Upgrade independent or lightly dependent design pattern projects to .NET 10.
Includes Builder, Visitor, Memento, Mediator, FlyWeight, ChainOfResponsibility, State, Iterator, Composite, TemplateMethod, Bridge, Proxy, Facade, Adapter, Command, Singleton, AbstractFactory.

**Done when**: These projects target net10.0 and build warning-free.

---

### 03-dependent-patterns: Upgrade dependent design pattern projects

Upgrade the design pattern projects that depend on base ones or have higher order: Decorator, Observer, Strategy, FactoryMethod.

**Done when**: These projects target net10.0 and build warning-free.

---

### 04-dry-solid-projects: Upgrade DRY and SOLID principle projects

Upgrade DRY.TestProject, DRY.WinForms, and all SOLID principle projects to .NET 10.

**Done when**: Remaining projects target net10.0, the entire solution builds without errors, and all tests pass.
