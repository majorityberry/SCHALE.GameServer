// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct EquipmentLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EquipmentLevelExcel GetRootAsEquipmentLevelExcel(ByteBuffer _bb) { return GetRootAsEquipmentLevelExcel(_bb, new EquipmentLevelExcel()); }
  public static EquipmentLevelExcel GetRootAsEquipmentLevelExcel(ByteBuffer _bb, EquipmentLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TierLevelExp(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int TierLevelExpLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetTierLevelExpBytes() { return __p.__vector_as_span<long>(6, 8); }
#else
  public ArraySegment<byte>? GetTierLevelExpBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public long[] GetTierLevelExpArray() { return __p.__vector_as_array<long>(6); }
  public long TotalExp(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int TotalExpLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetTotalExpBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetTotalExpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetTotalExpArray() { return __p.__vector_as_array<long>(8); }

  public static Offset<SCHALE.Common.FlatData.EquipmentLevelExcel> CreateEquipmentLevelExcel(FlatBufferBuilder builder,
      int Level = 0,
      VectorOffset TierLevelExpOffset = default(VectorOffset),
      VectorOffset TotalExpOffset = default(VectorOffset)) {
    builder.StartTable(3);
    EquipmentLevelExcel.AddTotalExp(builder, TotalExpOffset);
    EquipmentLevelExcel.AddTierLevelExp(builder, TierLevelExpOffset);
    EquipmentLevelExcel.AddLevel(builder, Level);
    return EquipmentLevelExcel.EndEquipmentLevelExcel(builder);
  }

  public static void StartEquipmentLevelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(0, level, 0); }
  public static void AddTierLevelExp(FlatBufferBuilder builder, VectorOffset tierLevelExpOffset) { builder.AddOffset(1, tierLevelExpOffset.Value, 0); }
  public static VectorOffset CreateTierLevelExpVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTierLevelExpVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTierLevelExpVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTierLevelExpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTierLevelExpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddTotalExp(FlatBufferBuilder builder, VectorOffset totalExpOffset) { builder.AddOffset(2, totalExpOffset.Value, 0); }
  public static VectorOffset CreateTotalExpVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTotalExpVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTotalExpVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.EquipmentLevelExcel> EndEquipmentLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EquipmentLevelExcel>(o);
  }
  public EquipmentLevelExcelT UnPack() {
    var _o = new EquipmentLevelExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EquipmentLevelExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EquipmentLevel");
    _o.Level = TableEncryptionService.Convert(this.Level, key);
    _o.TierLevelExp = new List<long>();
    for (var _j = 0; _j < this.TierLevelExpLength; ++_j) {_o.TierLevelExp.Add(TableEncryptionService.Convert(this.TierLevelExp(_j), key));}
    _o.TotalExp = new List<long>();
    for (var _j = 0; _j < this.TotalExpLength; ++_j) {_o.TotalExp.Add(TableEncryptionService.Convert(this.TotalExp(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.EquipmentLevelExcel> Pack(FlatBufferBuilder builder, EquipmentLevelExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.EquipmentLevelExcel>);
    var _TierLevelExp = default(VectorOffset);
    if (_o.TierLevelExp != null) {
      var __TierLevelExp = _o.TierLevelExp.ToArray();
      _TierLevelExp = CreateTierLevelExpVector(builder, __TierLevelExp);
    }
    var _TotalExp = default(VectorOffset);
    if (_o.TotalExp != null) {
      var __TotalExp = _o.TotalExp.ToArray();
      _TotalExp = CreateTotalExpVector(builder, __TotalExp);
    }
    return CreateEquipmentLevelExcel(
      builder,
      _o.Level,
      _TierLevelExp,
      _TotalExp);
  }
}

public class EquipmentLevelExcelT
{
  public int Level { get; set; }
  public List<long> TierLevelExp { get; set; }
  public List<long> TotalExp { get; set; }

  public EquipmentLevelExcelT() {
    this.Level = 0;
    this.TierLevelExp = null;
    this.TotalExp = null;
  }
}


static public class EquipmentLevelExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*TierLevelExp*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*TotalExp*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
