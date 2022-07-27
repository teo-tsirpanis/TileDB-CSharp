

The examples in this directory use [TileDB C API](https://tiledb-inc-tiledb.readthedocs-hosted.com/en/stable/c-api.html) bindings for C# generated by [ClangSharp](https://github.com/dotnet/ClangSharp).
The generated C# bindings are output into [sources/TileDB.Interop/Methods.cs](../../sources/TileDB.Interop/Methods.cs) and wrapped to support C# API functionality in [sources/TileDB.CSharp/](../../sources/TileDB.CSharp/).

We can create a context with `TileDB.Interop.Methods` directly or using the `TileDB.CSharp` API.

```c
// C API
#include <tiledb/tiledb.h>

tiledb_ctx_t* ctx;
tiledb_ctx_alloc(NULL, &ctx);
```
```c#
// C# Bindings
using TileDB.Interop;

tiledb_ctx_t* ctx;
Methods.tiledb_ctx_alloc(null, &ctx);
```
```c#
// C# API
using TileDB.CSharp;

var context = Context.GetDefault();
```