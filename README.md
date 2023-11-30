![Licensed under the MIT License](https://img.shields.io/github/license/TileDB-Inc/TileDB-CSharp.svg)
[![NuGet](https://img.shields.io/nuget/v/TileDB.CSharp.svg)](https://nuget.org/packages/TileDB.CSharp)
[![Test](https://github.com/TileDB-Inc/TileDB-CSharp/actions/workflows/tiledb-csharp.yml/badge.svg?branch=main&event=push)](https://github.com/TileDB-Inc/TileDB-CSharp/actions/workflows/tiledb-csharp.yml)

# TileDB Experimental C# API — Level 1

This branch contains the design for the next generation of the TileDB C# API.

> [!IMPORTANT]
> This API is a work in progress and it is not guaranteed to be actually shipped.

## Goals

* Provide the best possible way to use TileDB Embedded from C#. The best possible means:
    * Follows .NET conventions and idioms.
    * Is easy to use and understand.
    * Is efficient.
    * Is safe.
    * Its features are discoverable.
    * Hides the complexity of the underlying C API.
* Require few if any changes to the TileDB C API.
