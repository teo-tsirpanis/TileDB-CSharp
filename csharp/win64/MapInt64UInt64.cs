//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace tiledb {

public class MapInt64UInt64 : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<long, ulong>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MapInt64UInt64(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MapInt64UInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MapInt64UInt64() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tiledbcsPINVOKE.delete_MapInt64UInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


  public ulong this[long key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(long key, out ulong value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(ulong);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public global::System.Collections.Generic.ICollection<long> Keys {
    get {
      global::System.Collections.Generic.ICollection<long> keys = new global::System.Collections.Generic.List<long>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<ulong> Values {
    get {
      global::System.Collections.Generic.ICollection<ulong> vals = new global::System.Collections.Generic.List<ulong>();
      foreach (global::System.Collections.Generic.KeyValuePair<long, ulong> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<long, ulong> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<long, ulong> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<long, ulong> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<long, ulong>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<long, ulong>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<long> keyList = new global::System.Collections.Generic.List<long>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      long currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<long, ulong>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<long, ulong>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<long, ulong>>.GetEnumerator() {
    return new MapInt64UInt64Enumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MapInt64UInt64Enumerator(this);
  }

  public MapInt64UInt64Enumerator GetEnumerator() {
    return new MapInt64UInt64Enumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MapInt64UInt64Enumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<long, ulong>>
  {
    private MapInt64UInt64 collectionRef;
    private global::System.Collections.Generic.IList<long> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MapInt64UInt64Enumerator(MapInt64UInt64 collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<long>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<long, ulong> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<long, ulong>)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        long currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<long, ulong>(currentKey, collectionRef[currentKey]);
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }


  public MapInt64UInt64() : this(tiledbcsPINVOKE.new_MapInt64UInt64__SWIG_0(), true) {
  }

  public MapInt64UInt64(MapInt64UInt64 other) : this(tiledbcsPINVOKE.new_MapInt64UInt64__SWIG_1(MapInt64UInt64.getCPtr(other)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = tiledbcsPINVOKE.MapInt64UInt64_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = tiledbcsPINVOKE.MapInt64UInt64_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    tiledbcsPINVOKE.MapInt64UInt64_Clear(swigCPtr);
  }

  private ulong getitem(long key) {
    ulong ret = tiledbcsPINVOKE.MapInt64UInt64_getitem(swigCPtr, key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(long key, ulong x) {
    tiledbcsPINVOKE.MapInt64UInt64_setitem(swigCPtr, key, x);
  }

  public bool ContainsKey(long key) {
    bool ret = tiledbcsPINVOKE.MapInt64UInt64_ContainsKey(swigCPtr, key);
    return ret;
  }

  public void Add(long key, ulong value) {
    tiledbcsPINVOKE.MapInt64UInt64_Add(swigCPtr, key, value);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(long key) {
    bool ret = tiledbcsPINVOKE.MapInt64UInt64_Remove(swigCPtr, key);
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = tiledbcsPINVOKE.MapInt64UInt64_create_iterator_begin(swigCPtr);
    return ret;
  }

  private long get_next_key(global::System.IntPtr swigiterator) {
    long ret = tiledbcsPINVOKE.MapInt64UInt64_get_next_key(swigCPtr, swigiterator);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    tiledbcsPINVOKE.MapInt64UInt64_destroy_iterator(swigCPtr, swigiterator);
  }

}

}