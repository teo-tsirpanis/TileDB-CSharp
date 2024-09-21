using System;
using System.Runtime.CompilerServices;
using TileDB.CSharp.Marshalling.SafeHandles;
using TileDB.Interop;

namespace TileDB.CSharp;

/// <summary>
/// Represents a TileDB n-dimensional rectangle object.
/// </summary>
public sealed unsafe class NDRectangle : IDisposable
{
    private readonly NDRectangleHandle _handle;
    private readonly Context _ctx;

    /// <summary>
    /// Creates an <see cref="NDRectangle"/>.
    /// </summary>
    /// <param name="ctx">The <see cref="Context"/> to use.</param>
    /// <param name="domain">The <see cref="Domain"/> in which the <see cref="NDRectangle"/> is defined.</param>
    public NDRectangle(Context ctx, Domain domain)
    {
        _ctx = ctx;
        _handle = NDRectangleHandle.Create(_ctx, domain.Handle);
    }

    internal NDRectangle(Context ctx, NDRectangleHandle handle)
    {
        _ctx = ctx;
        _handle = handle;
    }

    /// <summary>
    /// Disposes this <see cref="NDRectangle"/>
    /// </summary>
    public void Dispose()
    {
        _handle.Dispose();
    }

    internal NDRectangleHandle Handle => _handle;

    private void SetRangeVar(uint dimensionIndex, string rangeStart, string rangeEnd)
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        using var ms_rangeStart = new MarshaledString(rangeStart);
        using var ms_rangeEnd = new MarshaledString(rangeEnd);
        tiledb_range_t range = new() { min = ms_rangeStart, min_size = (ulong)ms_rangeStart.Length, max = ms_rangeEnd, max_size = (ulong)ms_rangeEnd.Length };
        _ctx.handle_error(Methods.tiledb_ndrectangle_set_range(ctxHandle, handle, dimensionIndex, &range));
    }

    private void SetRangeVar(string dimensionName, string rangeStart, string rangeEnd)
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        using var ms_dimensionName = new MarshaledString(dimensionName);
        using var ms_rangeStart = new MarshaledString(rangeStart);
        using var ms_rangeEnd = new MarshaledString(rangeEnd);
        tiledb_range_t range = new() { min = ms_rangeStart, min_size = (ulong)ms_rangeStart.Length, max = ms_rangeEnd, max_size = (ulong)ms_rangeEnd.Length };
        _ctx.handle_error(Methods.tiledb_ndrectangle_set_range_for_name(ctxHandle, handle, ms_dimensionName, &range));
    }

    public void SetRange<T>(uint dimensionIndex, T rangeStart, T rangeEnd) where T : notnull
    {
        if (typeof(T) == typeof(string))
        {
            SetRangeVar(dimensionIndex, (string)(object)rangeStart, (string)(object)rangeEnd);
            return;
        }
        ErrorHandling.ThrowIfManagedType<T>();
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        tiledb_range_t range = new() { min = &rangeStart, min_size = (ulong)sizeof(T), max = &rangeEnd, max_size = (ulong)sizeof(T) };
        _ctx.handle_error(Methods.tiledb_ndrectangle_set_range(ctxHandle, handle, dimensionIndex, &range));
    }

    public void SetRange<T>(string dimensionName, T rangeStart, T rangeEnd) where T : notnull
    {
        if (typeof(T) == typeof(string))
        {
            SetRangeVar(dimensionName, (string)(object)rangeStart, (string)(object)rangeEnd);
            return;
        }
        ErrorHandling.ThrowIfManagedType<T>();
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        using var ms_dimensionName = new MarshaledString(dimensionName);
        tiledb_range_t range = new() { min = &rangeStart, min_size = (ulong)sizeof(T), max = &rangeEnd, max_size = (ulong)sizeof(T) };
        _ctx.handle_error(Methods.tiledb_ndrectangle_set_range_for_name(ctxHandle, handle, ms_dimensionName, &range));
    }

    private static unsafe (T Start, T End) GetRange<T>(in tiledb_range_t range) where T : notnull
    {
        return (ReadValue(range.min, range.min_size), ReadValue(range.max, range.max_size));

        static T ReadValue(void* ptr, ulong size)
        {
            var span = new ReadOnlySpan<byte>(ptr, checked((int)size));
            if (typeof(T) == typeof(string))
            {
                return (T)(object)MarshaledStringOut.GetString(span);
            }
            ErrorHandling.ThrowIfManagedType<T>();
            if (size != (ulong)Unsafe.SizeOf<T>())
                ThrowHelpers.ThrowTypeNotSupported();
            return Unsafe.ReadUnaligned<T>(ptr);
        }
    }

    private DataType GetDataType(uint dimensionIndex)
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        tiledb_datatype_t datatype;
        _ctx.handle_error(Methods.tiledb_ndrectangle_get_dtype(ctxHandle, handle, dimensionIndex, &datatype));
        return (DataType)datatype;
    }

    // Accept a char* instead of string to avoid double marshalling.
    private DataType GetDataType(sbyte* dimensionName)
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        tiledb_datatype_t datatype;
        _ctx.handle_error(Methods.tiledb_ndrectangle_get_dtype_from_name(ctxHandle, handle, dimensionName, &datatype));
        return (DataType)datatype;
    }

    public (T Start, T End) GetRange<T>(uint dimensionIndex) where T : notnull
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        ErrorHandling.CheckDataType<T>(GetDataType(dimensionIndex));
        tiledb_range_t range;
        _ctx.handle_error(Methods.tiledb_ndrectangle_get_range(ctxHandle, handle, dimensionIndex, &range));
        return GetRange<T>(range);
    }

    public (T Start, T End) GetRange<T>(string dimensionName) where T : notnull
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        using var ms_dimensionName = new MarshaledString(dimensionName);
        ErrorHandling.CheckDataType<T>(GetDataType(ms_dimensionName));
        tiledb_range_t range;
        _ctx.handle_error(Methods.tiledb_ndrectangle_get_range_from_name(ctxHandle, handle, ms_dimensionName, &range));
        return GetRange<T>(range);
    }
}
