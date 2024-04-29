// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct FieldInteractionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldInteractionExcel GetRootAsFieldInteractionExcel(ByteBuffer _bb) { return GetRootAsFieldInteractionExcel(_bb, new FieldInteractionExcel()); }
  public static FieldInteractionExcel GetRootAsFieldInteractionExcel(ByteBuffer _bb, FieldInteractionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldInteractionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FieldDateId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ShowEmoji { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string KeywordLocalize { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeywordLocalizeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetKeywordLocalizeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetKeywordLocalizeArray() { return __p.__vector_as_array<byte>(10); }
  public long FieldSeasonId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.FieldInteractionType InteractionType(int j) { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.FieldInteractionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.FieldInteractionType)0; }
  public int InteractionTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.FieldInteractionType> GetInteractionTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.FieldInteractionType>(14, 4); }
#else
  public ArraySegment<byte>? GetInteractionTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public SCHALE.Common.FlatData.FieldInteractionType[] GetInteractionTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.FieldInteractionType[] a = new SCHALE.Common.FlatData.FieldInteractionType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.FieldInteractionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long InteractionId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int InteractionIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetInteractionIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetInteractionIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetInteractionIdArray() { return __p.__vector_as_array<long>(16); }
  public SCHALE.Common.FlatData.FieldConditionClass ConditionClass { get { int o = __p.__offset(18); return o != 0 ? (SCHALE.Common.FlatData.FieldConditionClass)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.FieldConditionClass.AndOr; } }
  public long ConditionClassParameters(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionClassParametersLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionClassParametersBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetConditionClassParametersBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetConditionClassParametersArray() { return __p.__vector_as_array<long>(20); }
  public bool OnceOnly { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long ConditionIndex(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionIndexLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionIndexBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetConditionIndexBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetConditionIndexArray() { return __p.__vector_as_array<long>(24); }
  public SCHALE.Common.FlatData.FieldConditionType ConditionType(int j) { int o = __p.__offset(26); return o != 0 ? (SCHALE.Common.FlatData.FieldConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.FieldConditionType)0; }
  public int ConditionTypeLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.FieldConditionType> GetConditionTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.FieldConditionType>(26, 4); }
#else
  public ArraySegment<byte>? GetConditionTypeBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public SCHALE.Common.FlatData.FieldConditionType[] GetConditionTypeArray() { int o = __p.__offset(26); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.FieldConditionType[] a = new SCHALE.Common.FlatData.FieldConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.FieldConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ConditionId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetConditionIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetConditionIdArray() { return __p.__vector_as_array<long>(28); }
  public bool NegateCondition(int j) { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int NegateConditionLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetNegateConditionBytes() { return __p.__vector_as_span<bool>(30, 1); }
#else
  public ArraySegment<byte>? GetNegateConditionBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public bool[] GetNegateConditionArray() { return __p.__vector_as_array<bool>(30); }

  public static Offset<SCHALE.Common.FlatData.FieldInteractionExcel> CreateFieldInteractionExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long FieldDateId = 0,
      bool ShowEmoji = false,
      StringOffset KeywordLocalizeOffset = default(StringOffset),
      long FieldSeasonId = 0,
      VectorOffset InteractionTypeOffset = default(VectorOffset),
      VectorOffset InteractionIdOffset = default(VectorOffset),
      SCHALE.Common.FlatData.FieldConditionClass ConditionClass = SCHALE.Common.FlatData.FieldConditionClass.AndOr,
      VectorOffset ConditionClassParametersOffset = default(VectorOffset),
      bool OnceOnly = false,
      VectorOffset ConditionIndexOffset = default(VectorOffset),
      VectorOffset ConditionTypeOffset = default(VectorOffset),
      VectorOffset ConditionIdOffset = default(VectorOffset),
      VectorOffset NegateConditionOffset = default(VectorOffset)) {
    builder.StartTable(14);
    FieldInteractionExcel.AddFieldSeasonId(builder, FieldSeasonId);
    FieldInteractionExcel.AddFieldDateId(builder, FieldDateId);
    FieldInteractionExcel.AddUniqueId(builder, UniqueId);
    FieldInteractionExcel.AddNegateCondition(builder, NegateConditionOffset);
    FieldInteractionExcel.AddConditionId(builder, ConditionIdOffset);
    FieldInteractionExcel.AddConditionType(builder, ConditionTypeOffset);
    FieldInteractionExcel.AddConditionIndex(builder, ConditionIndexOffset);
    FieldInteractionExcel.AddConditionClassParameters(builder, ConditionClassParametersOffset);
    FieldInteractionExcel.AddConditionClass(builder, ConditionClass);
    FieldInteractionExcel.AddInteractionId(builder, InteractionIdOffset);
    FieldInteractionExcel.AddInteractionType(builder, InteractionTypeOffset);
    FieldInteractionExcel.AddKeywordLocalize(builder, KeywordLocalizeOffset);
    FieldInteractionExcel.AddOnceOnly(builder, OnceOnly);
    FieldInteractionExcel.AddShowEmoji(builder, ShowEmoji);
    return FieldInteractionExcel.EndFieldInteractionExcel(builder);
  }

  public static void StartFieldInteractionExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddFieldDateId(FlatBufferBuilder builder, long fieldDateId) { builder.AddLong(1, fieldDateId, 0); }
  public static void AddShowEmoji(FlatBufferBuilder builder, bool showEmoji) { builder.AddBool(2, showEmoji, false); }
  public static void AddKeywordLocalize(FlatBufferBuilder builder, StringOffset keywordLocalizeOffset) { builder.AddOffset(3, keywordLocalizeOffset.Value, 0); }
  public static void AddFieldSeasonId(FlatBufferBuilder builder, long fieldSeasonId) { builder.AddLong(4, fieldSeasonId, 0); }
  public static void AddInteractionType(FlatBufferBuilder builder, VectorOffset interactionTypeOffset) { builder.AddOffset(5, interactionTypeOffset.Value, 0); }
  public static VectorOffset CreateInteractionTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.FieldInteractionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInteractionTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.FieldInteractionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.FieldInteractionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.FieldInteractionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInteractionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInteractionId(FlatBufferBuilder builder, VectorOffset interactionIdOffset) { builder.AddOffset(6, interactionIdOffset.Value, 0); }
  public static VectorOffset CreateInteractionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInteractionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInteractionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInteractionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionClass(FlatBufferBuilder builder, SCHALE.Common.FlatData.FieldConditionClass conditionClass) { builder.AddInt(7, (int)conditionClass, 0); }
  public static void AddConditionClassParameters(FlatBufferBuilder builder, VectorOffset conditionClassParametersOffset) { builder.AddOffset(8, conditionClassParametersOffset.Value, 0); }
  public static VectorOffset CreateConditionClassParametersVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionClassParametersVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionClassParametersVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionClassParametersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionClassParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddOnceOnly(FlatBufferBuilder builder, bool onceOnly) { builder.AddBool(9, onceOnly, false); }
  public static void AddConditionIndex(FlatBufferBuilder builder, VectorOffset conditionIndexOffset) { builder.AddOffset(10, conditionIndexOffset.Value, 0); }
  public static VectorOffset CreateConditionIndexVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionIndexVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionType(FlatBufferBuilder builder, VectorOffset conditionTypeOffset) { builder.AddOffset(11, conditionTypeOffset.Value, 0); }
  public static VectorOffset CreateConditionTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.FieldConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.FieldConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.FieldConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.FieldConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConditionId(FlatBufferBuilder builder, VectorOffset conditionIdOffset) { builder.AddOffset(12, conditionIdOffset.Value, 0); }
  public static VectorOffset CreateConditionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddNegateCondition(FlatBufferBuilder builder, VectorOffset negateConditionOffset) { builder.AddOffset(13, negateConditionOffset.Value, 0); }
  public static VectorOffset CreateNegateConditionVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNegateConditionVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNegateConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNegateConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNegateConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<SCHALE.Common.FlatData.FieldInteractionExcel> EndFieldInteractionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FieldInteractionExcel>(o);
  }
  public FieldInteractionExcelT UnPack() {
    var _o = new FieldInteractionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldInteractionExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FieldInteraction");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.FieldDateId = TableEncryptionService.Convert(this.FieldDateId, key);
    _o.ShowEmoji = TableEncryptionService.Convert(this.ShowEmoji, key);
    _o.KeywordLocalize = TableEncryptionService.Convert(this.KeywordLocalize, key);
    _o.FieldSeasonId = TableEncryptionService.Convert(this.FieldSeasonId, key);
    _o.InteractionType = new List<SCHALE.Common.FlatData.FieldInteractionType>();
    for (var _j = 0; _j < this.InteractionTypeLength; ++_j) {_o.InteractionType.Add(TableEncryptionService.Convert(this.InteractionType(_j), key));}
    _o.InteractionId = new List<long>();
    for (var _j = 0; _j < this.InteractionIdLength; ++_j) {_o.InteractionId.Add(TableEncryptionService.Convert(this.InteractionId(_j), key));}
    _o.ConditionClass = TableEncryptionService.Convert(this.ConditionClass, key);
    _o.ConditionClassParameters = new List<long>();
    for (var _j = 0; _j < this.ConditionClassParametersLength; ++_j) {_o.ConditionClassParameters.Add(TableEncryptionService.Convert(this.ConditionClassParameters(_j), key));}
    _o.OnceOnly = TableEncryptionService.Convert(this.OnceOnly, key);
    _o.ConditionIndex = new List<long>();
    for (var _j = 0; _j < this.ConditionIndexLength; ++_j) {_o.ConditionIndex.Add(TableEncryptionService.Convert(this.ConditionIndex(_j), key));}
    _o.ConditionType = new List<SCHALE.Common.FlatData.FieldConditionType>();
    for (var _j = 0; _j < this.ConditionTypeLength; ++_j) {_o.ConditionType.Add(TableEncryptionService.Convert(this.ConditionType(_j), key));}
    _o.ConditionId = new List<long>();
    for (var _j = 0; _j < this.ConditionIdLength; ++_j) {_o.ConditionId.Add(TableEncryptionService.Convert(this.ConditionId(_j), key));}
    _o.NegateCondition = new List<bool>();
    for (var _j = 0; _j < this.NegateConditionLength; ++_j) {_o.NegateCondition.Add(TableEncryptionService.Convert(this.NegateCondition(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.FieldInteractionExcel> Pack(FlatBufferBuilder builder, FieldInteractionExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.FieldInteractionExcel>);
    var _KeywordLocalize = _o.KeywordLocalize == null ? default(StringOffset) : builder.CreateString(_o.KeywordLocalize);
    var _InteractionType = default(VectorOffset);
    if (_o.InteractionType != null) {
      var __InteractionType = _o.InteractionType.ToArray();
      _InteractionType = CreateInteractionTypeVector(builder, __InteractionType);
    }
    var _InteractionId = default(VectorOffset);
    if (_o.InteractionId != null) {
      var __InteractionId = _o.InteractionId.ToArray();
      _InteractionId = CreateInteractionIdVector(builder, __InteractionId);
    }
    var _ConditionClassParameters = default(VectorOffset);
    if (_o.ConditionClassParameters != null) {
      var __ConditionClassParameters = _o.ConditionClassParameters.ToArray();
      _ConditionClassParameters = CreateConditionClassParametersVector(builder, __ConditionClassParameters);
    }
    var _ConditionIndex = default(VectorOffset);
    if (_o.ConditionIndex != null) {
      var __ConditionIndex = _o.ConditionIndex.ToArray();
      _ConditionIndex = CreateConditionIndexVector(builder, __ConditionIndex);
    }
    var _ConditionType = default(VectorOffset);
    if (_o.ConditionType != null) {
      var __ConditionType = _o.ConditionType.ToArray();
      _ConditionType = CreateConditionTypeVector(builder, __ConditionType);
    }
    var _ConditionId = default(VectorOffset);
    if (_o.ConditionId != null) {
      var __ConditionId = _o.ConditionId.ToArray();
      _ConditionId = CreateConditionIdVector(builder, __ConditionId);
    }
    var _NegateCondition = default(VectorOffset);
    if (_o.NegateCondition != null) {
      var __NegateCondition = _o.NegateCondition.ToArray();
      _NegateCondition = CreateNegateConditionVector(builder, __NegateCondition);
    }
    return CreateFieldInteractionExcel(
      builder,
      _o.UniqueId,
      _o.FieldDateId,
      _o.ShowEmoji,
      _KeywordLocalize,
      _o.FieldSeasonId,
      _InteractionType,
      _InteractionId,
      _o.ConditionClass,
      _ConditionClassParameters,
      _o.OnceOnly,
      _ConditionIndex,
      _ConditionType,
      _ConditionId,
      _NegateCondition);
  }
}

public class FieldInteractionExcelT
{
  public long UniqueId { get; set; }
  public long FieldDateId { get; set; }
  public bool ShowEmoji { get; set; }
  public string KeywordLocalize { get; set; }
  public long FieldSeasonId { get; set; }
  public List<SCHALE.Common.FlatData.FieldInteractionType> InteractionType { get; set; }
  public List<long> InteractionId { get; set; }
  public SCHALE.Common.FlatData.FieldConditionClass ConditionClass { get; set; }
  public List<long> ConditionClassParameters { get; set; }
  public bool OnceOnly { get; set; }
  public List<long> ConditionIndex { get; set; }
  public List<SCHALE.Common.FlatData.FieldConditionType> ConditionType { get; set; }
  public List<long> ConditionId { get; set; }
  public List<bool> NegateCondition { get; set; }

  public FieldInteractionExcelT() {
    this.UniqueId = 0;
    this.FieldDateId = 0;
    this.ShowEmoji = false;
    this.KeywordLocalize = null;
    this.FieldSeasonId = 0;
    this.InteractionType = null;
    this.InteractionId = null;
    this.ConditionClass = SCHALE.Common.FlatData.FieldConditionClass.AndOr;
    this.ConditionClassParameters = null;
    this.OnceOnly = false;
    this.ConditionIndex = null;
    this.ConditionType = null;
    this.ConditionId = null;
    this.NegateCondition = null;
  }
}


static public class FieldInteractionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FieldDateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ShowEmoji*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 10 /*KeywordLocalize*/, false)
      && verifier.VerifyField(tablePos, 12 /*FieldSeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*InteractionType*/, 4 /*SCHALE.Common.FlatData.FieldInteractionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*InteractionId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 18 /*ConditionClass*/, 4 /*SCHALE.Common.FlatData.FieldConditionClass*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*ConditionClassParameters*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 22 /*OnceOnly*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*ConditionIndex*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*ConditionType*/, 4 /*SCHALE.Common.FlatData.FieldConditionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*ConditionId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*NegateCondition*/, 1 /*bool*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
