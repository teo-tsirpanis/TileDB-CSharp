//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TileDB {

public class Stats : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Stats(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Stats obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Stats() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          tiledbcsPINVOKE.delete_Stats(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static void enable() {
    tiledbcsPINVOKE.Stats_enable();
  }

  public static void disable() {
    tiledbcsPINVOKE.Stats_disable();
  }

  public static void reset() {
    tiledbcsPINVOKE.Stats_reset();
  }

  public static void dump() {
    tiledbcsPINVOKE.Stats_dump__SWIG_0();
  }

  public static void dump(SWIGTYPE_p_std__string out_) {
    tiledbcsPINVOKE.Stats_dump__SWIG_1(SWIGTYPE_p_std__string.getCPtr(out_));
  }

  public static void raw_dump() {
    tiledbcsPINVOKE.Stats_raw_dump__SWIG_0();
  }

  public static void raw_dump(SWIGTYPE_p_std__string out_) {
    tiledbcsPINVOKE.Stats_raw_dump__SWIG_1(SWIGTYPE_p_std__string.getCPtr(out_));
  }

  public Stats() : this(tiledbcsPINVOKE.new_Stats(), true) {
  }

}

}