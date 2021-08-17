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

public class Array : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Array(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Array obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Array() {
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
          tiledbcsPINVOKE.delete_Array(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Array(Context ctx, string array_uri, QueryType query_type) : this(tiledbcsPINVOKE.new_Array__SWIG_0(Context.getCPtr(ctx), array_uri, (int)query_type), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Array(Context ctx, string array_uri, QueryType querytype, EncryptionType encryptiontype, string encryption_key) : this(tiledbcsPINVOKE.new_Array__SWIG_1(Context.getCPtr(ctx), array_uri, (int)querytype, (int)encryptiontype, encryption_key), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Array(Context ctx, string array_uri, QueryType querytype, ulong timestamp) : this(tiledbcsPINVOKE.new_Array__SWIG_2(Context.getCPtr(ctx), array_uri, (int)querytype, timestamp), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Array(Context ctx, string array_uri, QueryType querytype, EncryptionType encryptiontype, string encryption_key, ulong timestamp) : this(tiledbcsPINVOKE.new_Array__SWIG_3(Context.getCPtr(ctx), array_uri, (int)querytype, (int)encryptiontype, encryption_key, timestamp), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Array(Array arg0) : this(tiledbcsPINVOKE.new_Array__SWIG_4(Array.getCPtr(arg0)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool is_open() {
    bool ret = tiledbcsPINVOKE.Array_is_open(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string uri() {
    string ret = tiledbcsPINVOKE.Array_uri(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArraySchema schema() {
    ArraySchema ret = new ArraySchema(tiledbcsPINVOKE.Array_schema(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void open(QueryType querytype) {
    tiledbcsPINVOKE.Array_open__SWIG_0(swigCPtr, (int)querytype);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void open(QueryType querytype, EncryptionType encryptiontype, string encryption_key) {
    tiledbcsPINVOKE.Array_open__SWIG_1(swigCPtr, (int)querytype, (int)encryptiontype, encryption_key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void open(QueryType querytype, ulong timestamp) {
    tiledbcsPINVOKE.Array_open__SWIG_2(swigCPtr, (int)querytype, timestamp);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void open(QueryType querytype, EncryptionType encryptiontype, string encryption_key, ulong timestamp) {
    tiledbcsPINVOKE.Array_open__SWIG_3(swigCPtr, (int)querytype, (int)encryptiontype, encryption_key, timestamp);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reopen() {
    tiledbcsPINVOKE.Array_reopen(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reopen_at(ulong timestamp) {
    tiledbcsPINVOKE.Array_reopen_at(swigCPtr, timestamp);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong timestamp() {
    ulong ret = tiledbcsPINVOKE.Array_timestamp(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void close() {
    tiledbcsPINVOKE.Array_close(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate(Context ctx, string uri, Config config) {
    tiledbcsPINVOKE.Array_consolidate__SWIG_0(Context.getCPtr(ctx), uri, Config.getCPtr(config));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate(Context ctx, string uri) {
    tiledbcsPINVOKE.Array_consolidate__SWIG_1(Context.getCPtr(ctx), uri);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate(Context ctx, string uri, EncryptionType encryptiontype, System.IntPtr encryption_key, uint key_length) {
    tiledbcsPINVOKE.Array_consolidate__SWIG_2(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key, key_length);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void vacuum(Context ctx, string uri, Config config) {
    tiledbcsPINVOKE.Array_vacuum__SWIG_0(Context.getCPtr(ctx), uri, Config.getCPtr(config));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void vacuum(Context ctx, string uri) {
    tiledbcsPINVOKE.Array_vacuum__SWIG_1(Context.getCPtr(ctx), uri);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate(Context ctx, string uri, EncryptionType encryptiontype, string encryption_key, Config config) {
    tiledbcsPINVOKE.Array_consolidate__SWIG_3(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key, Config.getCPtr(config));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate(Context ctx, string uri, EncryptionType encryptiontype, string encryption_key) {
    tiledbcsPINVOKE.Array_consolidate__SWIG_4(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create(string uri, ArraySchema schema) {
    tiledbcsPINVOKE.Array_create__SWIG_0(uri, ArraySchema.getCPtr(schema));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ArraySchema load_schema(Context ctx, string uri) {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.Array_load_schema(Context.getCPtr(ctx), uri);
    ArraySchema ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArraySchema(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void create(string uri, ArraySchema schema, EncryptionType encryptiontype, string encryption_key) {
    tiledbcsPINVOKE.Array_create__SWIG_1(uri, ArraySchema.getCPtr(schema), (int)encryptiontype, encryption_key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static EncryptionType encryption_type(Context ctx, string array_uri) {
    EncryptionType ret = (EncryptionType)tiledbcsPINVOKE.Array_encryption_type(Context.getCPtr(ctx), array_uri);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string non_empty_domain_json_str() {
    string ret = tiledbcsPINVOKE.Array_non_empty_domain_json_str(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorString non_empty_domain_str_vector_from_name(string dim_name) {
    VectorString ret = new VectorString(tiledbcsPINVOKE.Array_non_empty_domain_str_vector_from_name(swigCPtr, dim_name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PairStringString non_empty_domain_var(uint idx) {
    PairStringString ret = new PairStringString(tiledbcsPINVOKE.Array_non_empty_domain_var__SWIG_0(swigCPtr, idx), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PairStringString non_empty_domain_var(string name) {
    PairStringString ret = new PairStringString(tiledbcsPINVOKE.Array_non_empty_domain_var__SWIG_1(swigCPtr, name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryType query_type() {
    QueryType ret = (QueryType)tiledbcsPINVOKE.Array_query_type(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void consolidate_metadata(Context ctx, string uri, Config config) {
    tiledbcsPINVOKE.Array_consolidate_metadata__SWIG_0(Context.getCPtr(ctx), uri, Config.getCPtr(config));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate_metadata(Context ctx, string uri) {
    tiledbcsPINVOKE.Array_consolidate_metadata__SWIG_1(Context.getCPtr(ctx), uri);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate_metadata(Context ctx, string uri, EncryptionType encryptiontype, System.IntPtr encryption_key, uint key_length) {
    tiledbcsPINVOKE.Array_consolidate_metadata__SWIG_2(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key, key_length);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate_metadata(Context ctx, string uri, EncryptionType encryptiontype, string encryption_key, Config config) {
    tiledbcsPINVOKE.Array_consolidate_metadata__SWIG_3(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key, Config.getCPtr(config));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void consolidate_metadata(Context ctx, string uri, EncryptionType encryptiontype, string encryption_key) {
    tiledbcsPINVOKE.Array_consolidate_metadata__SWIG_4(Context.getCPtr(ctx), uri, (int)encryptiontype, encryption_key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void delete_metadata(string key) {
    tiledbcsPINVOKE.Array_delete_metadata(swigCPtr, key);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool has_metadata(string key, DataType valuetype) {
    bool ret = tiledbcsPINVOKE.Array_has_metadata(swigCPtr, key, (int)valuetype);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong metadata_num() {
    ulong ret = tiledbcsPINVOKE.Array_metadata_num(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
