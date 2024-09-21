using System;
using TileDB.CSharp.Marshalling.SafeHandles;
using TileDB.Interop;

namespace TileDB.CSharp;

/// <summary>
/// Represents a TileDB current domain object.
/// </summary>
public sealed unsafe class CurrentDomain : IDisposable
{
    private readonly CurrentDomainHandle _handle;
    private readonly Context _ctx;

    /// <summary>
    /// Creates a new <see cref="CurrentDomain"/>.
    /// </summary>
    /// <param name="ctx">The <see cref="Context"/> to use.</param>
    public CurrentDomain(Context ctx)
    {
        _ctx = ctx;
        _handle = CurrentDomainHandle.Create(_ctx);
    }

    internal CurrentDomain(Context ctx, CurrentDomainHandle handle)
    {
        _ctx = ctx;
        _handle = handle;
    }

    /// <summary>
    /// Disposes the <see cref="CurrentDomain"/>.
    /// </summary>
    public void Dispose()
    {
        _handle.Dispose();
    }

    internal CurrentDomainHandle Handle => _handle;

    /// <summary>
    /// The <see cref="CurrentDomain"/>'s type.
    /// </summary>
    public CurrentDomainType Type
    {
        get
        {
            using var ctxHandle = _ctx.Handle.Acquire();
            using var handle = _handle.Acquire();
            tiledb_current_domain_type_t type;
            ErrorHandling.ThrowOnError(Methods.tiledb_current_domain_get_type(ctxHandle, handle, &type));
            return (CurrentDomainType)type;
        }
    }

    /// <summary>
    /// Whether the <see cref="CurrentDomain"/> is empty.
    /// </summary>
    public bool IsEmpty
    {
        get
        {
            using var ctxHandle = _ctx.Handle.Acquire();
            using var handle = _handle.Acquire();
            uint ndim;
            ErrorHandling.ThrowOnError(Methods.tiledb_current_domain_get_is_empty(ctxHandle, handle, &ndim));
            return ndim != 0;
        }
    }

    /// <summary>
    /// Gets the <see cref="CurrentDomain"/>'s <see cref="NDRectangle"/>.
    /// </summary>
    public NDRectangle GetNDRectangle()
    {
        var handle = new NDRectangleHandle();
        var successful = false;
        tiledb_ndrectangle_handle_t* ndrectangle_p = null;
        try
        {
            using (var ctxHandle = _ctx.Handle.Acquire())
            using (var domainHandle = _handle.Acquire())
            {
                _ctx.handle_error(Methods.tiledb_current_domain_get_ndrectangle(ctxHandle, domainHandle, &ndrectangle_p));
            }
            successful = true;
        }
        finally
        {
            if (successful)
            {
                handle.InitHandle(ndrectangle_p);
            }
            else
            {
                handle.SetHandleAsInvalid();
            }
        }

        return new NDRectangle(_ctx, handle);
    }

    /// <summary>
    /// Sets an <see cref="NDRectangle"/> to the <see cref="CurrentDomain"/>.
    /// </summary>
    public void SetNDRectangle(NDRectangle ndRectangle)
    {
        using var ctxHandle = _ctx.Handle.Acquire();
        using var handle = _handle.Acquire();
        using var ndRectangleHandle = ndRectangle.Handle.Acquire();
        ErrorHandling.ThrowOnError(Methods.tiledb_current_domain_set_ndrectangle(ctxHandle, handle, ndRectangleHandle));
    }
}
