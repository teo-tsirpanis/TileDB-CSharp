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

public class Query : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Query(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Query obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Query() {
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
          tiledbcsPINVOKE.delete_Query(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Query(Context ctx, Array array, QueryType querytype) : this(tiledbcsPINVOKE.new_Query__SWIG_0(Context.getCPtr(ctx), Array.getCPtr(array), (int)querytype), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Context ctx, Array array) : this(tiledbcsPINVOKE.new_Query__SWIG_1(Context.getCPtr(ctx), Array.getCPtr(array)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query arg0) : this(tiledbcsPINVOKE.new_Query__SWIG_2(Query.getCPtr(arg0)), true) {
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Context context() {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.Query_context(swigCPtr);
    Context ret = (cPtr == global::System.IntPtr.Zero) ? null : new Context(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryType query_type() {
    QueryType ret = (QueryType)tiledbcsPINVOKE.Query_query_type(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query set_layout(LayoutType layouttype) {
    Query ret = new Query(tiledbcsPINVOKE.Query_set_layout(swigCPtr, (int)layouttype), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LayoutType query_layout() {
    LayoutType ret = (LayoutType)tiledbcsPINVOKE.Query_query_layout(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query set_condition(QueryCondition condition) {
    Query ret = new Query(tiledbcsPINVOKE.Query_set_condition(swigCPtr, QueryCondition.getCPtr(condition)), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Array array() {
    global::System.IntPtr cPtr = tiledbcsPINVOKE.Query_array(swigCPtr);
    Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new Array(cPtr, true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryStatus query_status() {
    QueryStatus ret = (QueryStatus)tiledbcsPINVOKE.Query_query_status(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool has_results() {
    bool ret = tiledbcsPINVOKE.Query_has_results(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryStatus submit() {
    QueryStatus ret = (QueryStatus)tiledbcsPINVOKE.Query_submit(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void finalize() {
    tiledbcsPINVOKE.Query_finalize(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public MapStringVectorUInt64 result_buffer_elements() {
    MapStringVectorUInt64 ret = new MapStringVectorUInt64(tiledbcsPINVOKE.Query_result_buffer_elements(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MapStringVectorUInt64 result_buffer_elements_nullable() {
    MapStringVectorUInt64 ret = new MapStringVectorUInt64(tiledbcsPINVOKE.Query_result_buffer_elements_nullable(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query add_range(uint dim_idx, string start, string end) {
    Query ret = new Query(tiledbcsPINVOKE.Query_add_range(swigCPtr, dim_idx, start, end), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query add_range_from_str_vector(uint dim_idx, VectorString vec) {
    Query ret = new Query(tiledbcsPINVOKE.Query_add_range_from_str_vector(swigCPtr, dim_idx, VectorString.getCPtr(vec)), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong range_num(uint dim_idx) {
    ulong ret = tiledbcsPINVOKE.Query_range_num(swigCPtr, dim_idx);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PairStringString range(uint dim_idx, ulong range_idx) {
    PairStringString ret = new PairStringString(tiledbcsPINVOKE.Query_range(swigCPtr, dim_idx, range_idx), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong est_result_size(string attr_name) {
    ulong ret = tiledbcsPINVOKE.Query_est_result_size(swigCPtr, attr_name);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorUInt64 est_result_size_var(string attr_name) {
    VectorUInt64 ret = new VectorUInt64(tiledbcsPINVOKE.Query_est_result_size_var(swigCPtr, attr_name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorUInt64 est_result_size_nullable(string attr_name) {
    VectorUInt64 ret = new VectorUInt64(tiledbcsPINVOKE.Query_est_result_size_nullable(swigCPtr, attr_name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorUInt64 est_result_size_var_nullable(string attr_name) {
    VectorUInt64 ret = new VectorUInt64(tiledbcsPINVOKE.Query_est_result_size_var_nullable(swigCPtr, attr_name), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint fragment_num() {
    uint ret = tiledbcsPINVOKE.Query_fragment_num(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string fragment_uri(uint idx) {
    string ret = tiledbcsPINVOKE.Query_fragment_uri(swigCPtr, idx);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PairUInt64UInt64 fragment_timestamp_range(uint idx) {
    PairUInt64UInt64 ret = new PairUInt64UInt64(tiledbcsPINVOKE.Query_fragment_timestamp_range(swigCPtr, idx), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_int32_subarray(VectorInt32 v) {
    tiledbcsPINVOKE.Query_set_int32_subarray(swigCPtr, VectorInt32.getCPtr(v));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_subarray(VectorUInt32 v) {
    tiledbcsPINVOKE.Query_set_uint32_subarray(swigCPtr, VectorUInt32.getCPtr(v));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_subarray(VectorInt64 v) {
    tiledbcsPINVOKE.Query_set_int64_subarray(swigCPtr, VectorInt64.getCPtr(v));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_subarray(VectorUInt64 v) {
    tiledbcsPINVOKE.Query_set_uint64_subarray(swigCPtr, VectorUInt64.getCPtr(v));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query set_config(Config config) {
    Query ret = new Query(tiledbcsPINVOKE.Query_set_config(swigCPtr, Config.getCPtr(config)), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Config config() {
    Config ret = new Config(tiledbcsPINVOKE.Query_config(swigCPtr), true);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_int32_coordinates(VectorInt32 buf) {
    tiledbcsPINVOKE.Query_set_int32_coordinates(swigCPtr, VectorInt32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_coordinates(VectorUInt32 buf) {
    tiledbcsPINVOKE.Query_set_uint32_coordinates(swigCPtr, VectorUInt32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_coordinates(VectorInt64 buf) {
    tiledbcsPINVOKE.Query_set_int64_coordinates(swigCPtr, VectorInt64.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_coordinates(VectorUInt64 buf) {
    tiledbcsPINVOKE.Query_set_uint64_coordinates(swigCPtr, VectorUInt64.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_float32_coordinates(VectorFloat32 buf) {
    tiledbcsPINVOKE.Query_set_float32_coordinates(swigCPtr, VectorFloat32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_double_coordinates(VectorDouble buf) {
    tiledbcsPINVOKE.Query_set_double_coordinates(swigCPtr, VectorDouble.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_char_vector_buffer(string attr, VectorChar buf) {
    tiledbcsPINVOKE.Query_set_char_vector_buffer(swigCPtr, attr, VectorChar.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_char_vector_buffer_with_offsets(string attr, VectorChar buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_char_vector_buffer_with_offsets(swigCPtr, attr, VectorChar.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_char_vector_buffer_with_validity(string attr, VectorChar buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_char_vector_buffer_with_validity(swigCPtr, attr, VectorChar.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_char_vector_buffer_with_offsets_validity(string attr, VectorChar buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_char_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorChar.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int32_vector_buffer(string attr, VectorInt32 buf) {
    tiledbcsPINVOKE.Query_set_int32_vector_buffer(swigCPtr, attr, VectorInt32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int32_vector_buffer_with_offsets(string attr, VectorInt32 buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_int32_vector_buffer_with_offsets(swigCPtr, attr, VectorInt32.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int32_vector_buffer_with_validity(string attr, VectorInt32 buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_int32_vector_buffer_with_validity(swigCPtr, attr, VectorInt32.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int32_vector_buffer_with_offsets_validity(string attr, VectorInt32 buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_int32_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorInt32.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_vector_buffer(string attr, VectorInt64 buf) {
    tiledbcsPINVOKE.Query_set_int64_vector_buffer(swigCPtr, attr, VectorInt64.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_vector_buffer_with_offsets(string attr, VectorInt64 buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_int64_vector_buffer_with_offsets(swigCPtr, attr, VectorInt64.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_vector_buffer_with_validity(string attr, VectorInt64 buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_int64_vector_buffer_with_validity(swigCPtr, attr, VectorInt64.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_int64_vector_buffer_with_offsets_validity(string attr, VectorInt64 buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_int64_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorInt64.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_vector_buffer(string attr, VectorUInt32 buf) {
    tiledbcsPINVOKE.Query_set_uint32_vector_buffer(swigCPtr, attr, VectorUInt32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_vector_buffer_with_offsets(string attr, VectorUInt32 buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_uint32_vector_buffer_with_offsets(swigCPtr, attr, VectorUInt32.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_vector_buffer_with_validity(string attr, VectorUInt32 buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_uint32_vector_buffer_with_validity(swigCPtr, attr, VectorUInt32.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint32_vector_buffer_with_offsets_validity(string attr, VectorUInt32 buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_uint32_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorUInt32.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_vector_buffer(string attr, VectorUInt64 buf) {
    tiledbcsPINVOKE.Query_set_uint64_vector_buffer(swigCPtr, attr, VectorUInt64.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_vector_buffer_with_offsets(string attr, VectorUInt64 buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_uint64_vector_buffer_with_offsets(swigCPtr, attr, VectorUInt64.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_vector_buffer_with_validity(string attr, VectorUInt64 buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_uint64_vector_buffer_with_validity(swigCPtr, attr, VectorUInt64.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uint64_vector_buffer_with_offsets_validity(string attr, VectorUInt64 buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_uint64_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorUInt64.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_float32_vector_buffer(string attr, VectorFloat32 buf) {
    tiledbcsPINVOKE.Query_set_float32_vector_buffer(swigCPtr, attr, VectorFloat32.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_float32_vector_buffer_with_offsets(string attr, VectorFloat32 buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_float32_vector_buffer_with_offsets(swigCPtr, attr, VectorFloat32.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_float32_vector_buffer_with_validity(string attr, VectorFloat32 buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_float32_vector_buffer_with_validity(swigCPtr, attr, VectorFloat32.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_float32_vector_buffer_with_offsets_validity(string attr, VectorFloat32 buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_float32_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorFloat32.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_double_vector_buffer(string attr, VectorDouble buf) {
    tiledbcsPINVOKE.Query_set_double_vector_buffer(swigCPtr, attr, VectorDouble.getCPtr(buf));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_double_vector_buffer_with_offsets(string attr, VectorDouble buf, VectorUInt64 offsets) {
    tiledbcsPINVOKE.Query_set_double_vector_buffer_with_offsets(swigCPtr, attr, VectorDouble.getCPtr(buf), VectorUInt64.getCPtr(offsets));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_double_vector_buffer_with_validity(string attr, VectorDouble buf, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_double_vector_buffer_with_validity(swigCPtr, attr, VectorDouble.getCPtr(buf), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_double_vector_buffer_with_offsets_validity(string attr, VectorDouble buf, VectorUInt64 offsets, VectorUInt8 validity) {
    tiledbcsPINVOKE.Query_set_double_vector_buffer_with_offsets_validity(swigCPtr, attr, VectorDouble.getCPtr(buf), VectorUInt64.getCPtr(offsets), VectorUInt8.getCPtr(validity));
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string stats() {
    string ret = tiledbcsPINVOKE.Query_stats(swigCPtr);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string to_str(QueryType type) {
    string ret = tiledbcsPINVOKE.Query_to_str((int)type);
    if (tiledbcsPINVOKE.SWIGPendingException.Pending) throw tiledbcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
