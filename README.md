NodeGraph
===========

## Concept

This is the `UPM` repository for NodeGraph, a generic C# Node & Graph abstraction framework.

Feel free to send feedback, submit pull requests, or open issues!

## Requirements

- This packages requires access to the `System` and `System.Collections.Generic` namespaces, which should be trivial for
any standard project package.
- Tested in Unity 2019.4.0f1, should work in anything newer.
- This package utilizes C# language features introduced in C# 8.0, and thus requires a compiler that supports that, eg:
.NET Core 3.x or .NET 5.0+

## Installation

Install it via the Unity Package Manager by:
- Opening your project in Unity
- Open the Package Manager window (`Window > Package Manager`)
- Click the `+` button in the top left corner of the window
- Select `Add package from git URL...`
- Enter the following url, and you'll be up to date: `https://github.com/RadialGames/NodeGraph.git`

Or if you aren't using Unity, just grab the C# files and start using them as-is. Nothing in this package requires Unity;
and there are no Unity-specific dependencies. You can use these files directly in any C# project.

## Usage

All files in this package are in the `Radial.NodeGraph` namespace. Access them by adding the following to the top of your
files:

```c#
using Radial.NodeGraph;
```

### QuickStart

// TODO: Documentation