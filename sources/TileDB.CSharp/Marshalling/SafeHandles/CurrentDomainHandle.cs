using System;
using System.Runtime.InteropServices;
using TileDB.Interop;

namespace TileDB.CSharp.Marshalling.SafeHandles;

internal unsafe sealed class CurrentDomainHandle : SafeHandle
{
    public CurrentDomainHandle() : base(IntPtr.Zero, true) { }

    public CurrentDomainHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { SetHandle(handle); }

    public static CurrentDomainHandle Create(Context context)
    {
        var handle = new CurrentDomainHandle();
        var successful = false;
        tiledb_current_domain_handle_t* currentDomain = null;
        try
        {
            using var contextHandle = context.Handle.Acquire();
            context.handle_error(Methods.tiledb_current_domain_create(contextHandle, &currentDomain));
            successful = true;
        }
        finally
        {
            if (successful)
            {
                handle.InitHandle(currentDomain);
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
            return Methods.tiledb_current_domain_free((tiledb_current_domain_handle_t**)p) == 0;
        }
    }

    internal void InitHandle(tiledb_current_domain_handle_t* h) { SetHandle((IntPtr)h); }
    public override bool IsInvalid => handle == IntPtr.Zero;

    public SafeHandleHolder<tiledb_current_domain_handle_t> Acquire() => new(this);
}
