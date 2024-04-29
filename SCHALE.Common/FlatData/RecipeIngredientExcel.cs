// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct RecipeIngredientExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RecipeIngredientExcel GetRootAsRecipeIngredientExcel(ByteBuffer _bb) { return GetRootAsRecipeIngredientExcel(_bb, new RecipeIngredientExcel()); }
  public static RecipeIngredientExcel GetRootAsRecipeIngredientExcel(ByteBuffer _bb, RecipeIngredientExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeIngredientExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.RecipeType RecipeType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.RecipeType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.RecipeType.None; } }
  public SCHALE.Common.FlatData.ParcelType CostParcelType(int j) { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int CostParcelTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetCostParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(8, 4); }
#else
  public ArraySegment<byte>? GetCostParcelTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetCostParcelTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long CostId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CostIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCostIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetCostIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetCostIdArray() { return __p.__vector_as_array<long>(10); }
  public long CostAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CostAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCostAmountBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetCostAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetCostAmountArray() { return __p.__vector_as_array<long>(12); }
  public SCHALE.Common.FlatData.ParcelType IngredientParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int IngredientParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetIngredientParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetIngredientParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetIngredientParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long IngredientId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int IngredientIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetIngredientIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetIngredientIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetIngredientIdArray() { return __p.__vector_as_array<long>(16); }
  public long IngredientAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int IngredientAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetIngredientAmountBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetIngredientAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetIngredientAmountArray() { return __p.__vector_as_array<long>(18); }
  public long CostTimeInSecond { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.RecipeIngredientExcel> CreateRecipeIngredientExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.RecipeType RecipeType = SCHALE.Common.FlatData.RecipeType.None,
      VectorOffset CostParcelTypeOffset = default(VectorOffset),
      VectorOffset CostIdOffset = default(VectorOffset),
      VectorOffset CostAmountOffset = default(VectorOffset),
      VectorOffset IngredientParcelTypeOffset = default(VectorOffset),
      VectorOffset IngredientIdOffset = default(VectorOffset),
      VectorOffset IngredientAmountOffset = default(VectorOffset),
      long CostTimeInSecond = 0) {
    builder.StartTable(9);
    RecipeIngredientExcel.AddCostTimeInSecond(builder, CostTimeInSecond);
    RecipeIngredientExcel.AddId(builder, Id);
    RecipeIngredientExcel.AddIngredientAmount(builder, IngredientAmountOffset);
    RecipeIngredientExcel.AddIngredientId(builder, IngredientIdOffset);
    RecipeIngredientExcel.AddIngredientParcelType(builder, IngredientParcelTypeOffset);
    RecipeIngredientExcel.AddCostAmount(builder, CostAmountOffset);
    RecipeIngredientExcel.AddCostId(builder, CostIdOffset);
    RecipeIngredientExcel.AddCostParcelType(builder, CostParcelTypeOffset);
    RecipeIngredientExcel.AddRecipeType(builder, RecipeType);
    return RecipeIngredientExcel.EndRecipeIngredientExcel(builder);
  }

  public static void StartRecipeIngredientExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddRecipeType(FlatBufferBuilder builder, SCHALE.Common.FlatData.RecipeType recipeType) { builder.AddInt(1, (int)recipeType, 0); }
  public static void AddCostParcelType(FlatBufferBuilder builder, VectorOffset costParcelTypeOffset) { builder.AddOffset(2, costParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateCostParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostId(FlatBufferBuilder builder, VectorOffset costIdOffset) { builder.AddOffset(3, costIdOffset.Value, 0); }
  public static VectorOffset CreateCostIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCostAmount(FlatBufferBuilder builder, VectorOffset costAmountOffset) { builder.AddOffset(4, costAmountOffset.Value, 0); }
  public static VectorOffset CreateCostAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIngredientParcelType(FlatBufferBuilder builder, VectorOffset ingredientParcelTypeOffset) { builder.AddOffset(5, ingredientParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateIngredientParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIngredientParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIngredientParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIngredientId(FlatBufferBuilder builder, VectorOffset ingredientIdOffset) { builder.AddOffset(6, ingredientIdOffset.Value, 0); }
  public static VectorOffset CreateIngredientIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIngredientIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIngredientIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIngredientAmount(FlatBufferBuilder builder, VectorOffset ingredientAmountOffset) { builder.AddOffset(7, ingredientAmountOffset.Value, 0); }
  public static VectorOffset CreateIngredientAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIngredientAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIngredientAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIngredientAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCostTimeInSecond(FlatBufferBuilder builder, long costTimeInSecond) { builder.AddLong(8, costTimeInSecond, 0); }
  public static Offset<SCHALE.Common.FlatData.RecipeIngredientExcel> EndRecipeIngredientExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.RecipeIngredientExcel>(o);
  }
  public RecipeIngredientExcelT UnPack() {
    var _o = new RecipeIngredientExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RecipeIngredientExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("RecipeIngredient");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.RecipeType = TableEncryptionService.Convert(this.RecipeType, key);
    _o.CostParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.CostParcelTypeLength; ++_j) {_o.CostParcelType.Add(TableEncryptionService.Convert(this.CostParcelType(_j), key));}
    _o.CostId = new List<long>();
    for (var _j = 0; _j < this.CostIdLength; ++_j) {_o.CostId.Add(TableEncryptionService.Convert(this.CostId(_j), key));}
    _o.CostAmount = new List<long>();
    for (var _j = 0; _j < this.CostAmountLength; ++_j) {_o.CostAmount.Add(TableEncryptionService.Convert(this.CostAmount(_j), key));}
    _o.IngredientParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.IngredientParcelTypeLength; ++_j) {_o.IngredientParcelType.Add(TableEncryptionService.Convert(this.IngredientParcelType(_j), key));}
    _o.IngredientId = new List<long>();
    for (var _j = 0; _j < this.IngredientIdLength; ++_j) {_o.IngredientId.Add(TableEncryptionService.Convert(this.IngredientId(_j), key));}
    _o.IngredientAmount = new List<long>();
    for (var _j = 0; _j < this.IngredientAmountLength; ++_j) {_o.IngredientAmount.Add(TableEncryptionService.Convert(this.IngredientAmount(_j), key));}
    _o.CostTimeInSecond = TableEncryptionService.Convert(this.CostTimeInSecond, key);
  }
  public static Offset<SCHALE.Common.FlatData.RecipeIngredientExcel> Pack(FlatBufferBuilder builder, RecipeIngredientExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.RecipeIngredientExcel>);
    var _CostParcelType = default(VectorOffset);
    if (_o.CostParcelType != null) {
      var __CostParcelType = _o.CostParcelType.ToArray();
      _CostParcelType = CreateCostParcelTypeVector(builder, __CostParcelType);
    }
    var _CostId = default(VectorOffset);
    if (_o.CostId != null) {
      var __CostId = _o.CostId.ToArray();
      _CostId = CreateCostIdVector(builder, __CostId);
    }
    var _CostAmount = default(VectorOffset);
    if (_o.CostAmount != null) {
      var __CostAmount = _o.CostAmount.ToArray();
      _CostAmount = CreateCostAmountVector(builder, __CostAmount);
    }
    var _IngredientParcelType = default(VectorOffset);
    if (_o.IngredientParcelType != null) {
      var __IngredientParcelType = _o.IngredientParcelType.ToArray();
      _IngredientParcelType = CreateIngredientParcelTypeVector(builder, __IngredientParcelType);
    }
    var _IngredientId = default(VectorOffset);
    if (_o.IngredientId != null) {
      var __IngredientId = _o.IngredientId.ToArray();
      _IngredientId = CreateIngredientIdVector(builder, __IngredientId);
    }
    var _IngredientAmount = default(VectorOffset);
    if (_o.IngredientAmount != null) {
      var __IngredientAmount = _o.IngredientAmount.ToArray();
      _IngredientAmount = CreateIngredientAmountVector(builder, __IngredientAmount);
    }
    return CreateRecipeIngredientExcel(
      builder,
      _o.Id,
      _o.RecipeType,
      _CostParcelType,
      _CostId,
      _CostAmount,
      _IngredientParcelType,
      _IngredientId,
      _IngredientAmount,
      _o.CostTimeInSecond);
  }
}

public class RecipeIngredientExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.RecipeType RecipeType { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> CostParcelType { get; set; }
  public List<long> CostId { get; set; }
  public List<long> CostAmount { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> IngredientParcelType { get; set; }
  public List<long> IngredientId { get; set; }
  public List<long> IngredientAmount { get; set; }
  public long CostTimeInSecond { get; set; }

  public RecipeIngredientExcelT() {
    this.Id = 0;
    this.RecipeType = SCHALE.Common.FlatData.RecipeType.None;
    this.CostParcelType = null;
    this.CostId = null;
    this.CostAmount = null;
    this.IngredientParcelType = null;
    this.IngredientId = null;
    this.IngredientAmount = null;
    this.CostTimeInSecond = 0;
  }
}


static public class RecipeIngredientExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RecipeType*/, 4 /*SCHALE.Common.FlatData.RecipeType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*CostParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*CostId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*CostAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*IngredientParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*IngredientId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*IngredientAmount*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 20 /*CostTimeInSecond*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
