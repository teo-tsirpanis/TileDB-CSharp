using System;
using System.Runtime.InteropServices;
using TileDB.Interop;

namespace TileDB.CSharp.Marshalling.SafeHandles;

internal unsafe sealed class NDRectangleHandle : SafeHandle
{
    public NDRectangleHandle() : base(IntPtr.Zero, true) { }

    public NDRectangleHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { SetHandle(handle); }

    public static NDRectangleHandle Create(Context context, DomainHandle domain)
    {
        var handle = new NDRectangleHandle();
        var successful = false;
        tiledb_ndrectangle_handle_t* ndRectangle = null;
        try
        {
            using var contextHandle = context.Handle.Acquire();
            using var domainHandleHolder = domain.Acquire();
            context.handle_error(Methods.tiledb_ndrectangle_alloc(contextHandle, domainHandleHolder, &ndRectangle));
            successful = true;
        }
        finally
        {
            if (successful)
            {
                handle.InitHandle(ndRectangle);
            }
            else
            {
                handle.SetHandleAsInvalid();
            }
        }

        return handle;
    }

    protected override bool ReleaseHandle()
    {
        fixed (IntPtr* p = &handle)
        {
            return Methods.tiledb_ndrectangle_free((tiledb_ndrectangle_handle_t**)p) == 0;
        }
    }

    internal void InitHandle(tiledb_ndrectangle_handle_t* h) { SetHandle((IntPtr)h); }
    public override bool IsInvalid => handle == IntPtr.Zero;

    public SafeHandleHolder<tiledb_ndrectangle_handle_t> Acquire() => new(this);
}
