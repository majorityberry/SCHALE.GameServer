// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct RaidSeasonManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RaidSeasonManageExcel GetRootAsRaidSeasonManageExcel(ByteBuffer _bb) { return GetRootAsRaidSeasonManageExcel(_bb, new RaidSeasonManageExcel()); }
  public static RaidSeasonManageExcel GetRootAsRaidSeasonManageExcel(ByteBuffer _bb, RaidSeasonManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidSeasonManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonDisplay { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SeasonStartData { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonStartDataBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSeasonStartDataBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSeasonStartDataArray() { return __p.__vector_as_array<byte>(8); }
  public string SeasonEndData { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonEndDataBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSeasonEndDataBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSeasonEndDataArray() { return __p.__vector_as_array<byte>(10); }
  public string SettlementEndDate { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSettlementEndDateBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSettlementEndDateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSettlementEndDateArray() { return __p.__vector_as_array<byte>(12); }
  public string OpenRaidBossGroup(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int OpenRaidBossGroupLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long RankingRewardGroupId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxSeasonRewardGauage { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StackedSeasonRewardGauge(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StackedSeasonRewardGaugeLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetStackedSeasonRewardGaugeArray() { return __p.__vector_as_array<long>(20); }
  public long SeasonRewardId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetSeasonRewardIdArray() { return __p.__vector_as_array<long>(22); }

  public static Offset<SCHALE.Common.FlatData.RaidSeasonManageExcel> CreateRaidSeasonManageExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long SeasonDisplay = 0,
      StringOffset SeasonStartDataOffset = default(StringOffset),
      StringOffset SeasonEndDataOffset = default(StringOffset),
      StringOffset SettlementEndDateOffset = default(StringOffset),
      VectorOffset OpenRaidBossGroupOffset = default(VectorOffset),
      long RankingRewardGroupId = 0,
      int MaxSeasonRewardGauage = 0,
      VectorOffset StackedSeasonRewardGaugeOffset = default(VectorOffset),
      VectorOffset SeasonRewardIdOffset = default(VectorOffset)) {
    builder.StartTable(10);
    RaidSeasonManageExcel.AddRankingRewardGroupId(builder, RankingRewardGroupId);
    RaidSeasonManageExcel.AddSeasonDisplay(builder, SeasonDisplay);
    RaidSeasonManageExcel.AddSeasonId(builder, SeasonId);
    RaidSeasonManageExcel.AddSeasonRewardId(builder, SeasonRewardIdOffset);
    RaidSeasonManageExcel.AddStackedSeasonRewardGauge(builder, StackedSeasonRewardGaugeOffset);
    RaidSeasonManageExcel.AddMaxSeasonRewardGauage(builder, MaxSeasonRewardGauage);
    RaidSeasonManageExcel.AddOpenRaidBossGroup(builder, OpenRaidBossGroupOffset);
    RaidSeasonManageExcel.AddSettlementEndDate(builder, SettlementEndDateOffset);
    RaidSeasonManageExcel.AddSeasonEndData(builder, SeasonEndDataOffset);
    RaidSeasonManageExcel.AddSeasonStartData(builder, SeasonStartDataOffset);
    return RaidSeasonManageExcel.EndRaidSeasonManageExcel(builder);
  }

  public static void StartRaidSeasonManageExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(0, seasonId, 0); }
  public static void AddSeasonDisplay(FlatBufferBuilder builder, long seasonDisplay) { builder.AddLong(1, seasonDisplay, 0); }
  public static void AddSeasonStartData(FlatBufferBuilder builder, StringOffset seasonStartDataOffset) { builder.AddOffset(2, seasonStartDataOffset.Value, 0); }
  public static void AddSeasonEndData(FlatBufferBuilder builder, StringOffset seasonEndDataOffset) { builder.AddOffset(3, seasonEndDataOffset.Value, 0); }
  public static void AddSettlementEndDate(FlatBufferBuilder builder, StringOffset settlementEndDateOffset) { builder.AddOffset(4, settlementEndDateOffset.Value, 0); }
  public static void AddOpenRaidBossGroup(FlatBufferBuilder builder, VectorOffset openRaidBossGroupOffset) { builder.AddOffset(5, openRaidBossGroupOffset.Value, 0); }
  public static VectorOffset CreateOpenRaidBossGroupVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenRaidBossGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOpenRaidBossGroupVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRankingRewardGroupId(FlatBufferBuilder builder, long rankingRewardGroupId) { builder.AddLong(6, rankingRewardGroupId, 0); }
  public static void AddMaxSeasonRewardGauage(FlatBufferBuilder builder, int maxSeasonRewardGauage) { builder.AddInt(7, maxSeasonRewardGauage, 0); }
  public static void AddStackedSeasonRewardGauge(FlatBufferBuilder builder, VectorOffset stackedSeasonRewardGaugeOffset) { builder.AddOffset(8, stackedSeasonRewardGaugeOffset.Value, 0); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, VectorOffset seasonRewardIdOffset) { builder.AddOffset(9, seasonRewardIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.RaidSeasonManageExcel> EndRaidSeasonManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.RaidSeasonManageExcel>(o);
  }
  public RaidSeasonManageExcelT UnPack() {
    var _o = new RaidSeasonManageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RaidSeasonManageExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("RaidSeasonManage");
    _o.SeasonId = TableEncryptionService.Convert(this.SeasonId, key);
    _o.SeasonDisplay = TableEncryptionService.Convert(this.SeasonDisplay, key);
    _o.SeasonStartData = TableEncryptionService.Convert(this.SeasonStartData, key);
    _o.SeasonEndData = TableEncryptionService.Convert(this.SeasonEndData, key);
    _o.SettlementEndDate = TableEncryptionService.Convert(this.SettlementEndDate, key);
    _o.OpenRaidBossGroup = new List<string>();
    for (var _j = 0; _j < this.OpenRaidBossGroupLength; ++_j) {_o.OpenRaidBossGroup.Add(TableEncryptionService.Convert(this.OpenRaidBossGroup(_j), key));}
    _o.RankingRewardGroupId = TableEncryptionService.Convert(this.RankingRewardGroupId, key);
    _o.MaxSeasonRewardGauage = TableEncryptionService.Convert(this.MaxSeasonRewardGauage, key);
    _o.StackedSeasonRewardGauge = new List<long>();
    for (var _j = 0; _j < this.StackedSeasonRewardGaugeLength; ++_j) {_o.StackedSeasonRewardGauge.Add(TableEncryptionService.Convert(this.StackedSeasonRewardGauge(_j), key));}
    _o.SeasonRewardId = new List<long>();
    for (var _j = 0; _j < this.SeasonRewardIdLength; ++_j) {_o.SeasonRewardId.Add(TableEncryptionService.Convert(this.SeasonRewardId(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.RaidSeasonManageExcel> Pack(FlatBufferBuilder builder, RaidSeasonManageExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.RaidSeasonManageExcel>);
    var _SeasonStartData = _o.SeasonStartData == null ? default(StringOffset) : builder.CreateString(_o.SeasonStartData);
    var _SeasonEndData = _o.SeasonEndData == null ? default(StringOffset) : builder.CreateString(_o.SeasonEndData);
    var _SettlementEndDate = _o.SettlementEndDate == null ? default(StringOffset) : builder.CreateString(_o.SettlementEndDate);
    var _OpenRaidBossGroup = default(VectorOffset);
    if (_o.OpenRaidBossGroup != null) {
      var __OpenRaidBossGroup = new StringOffset[_o.OpenRaidBossGroup.Count];
      for (var _j = 0; _j < __OpenRaidBossGroup.Length; ++_j) { __OpenRaidBossGroup[_j] = builder.CreateString(_o.OpenRaidBossGroup[_j]); }
      _OpenRaidBossGroup = CreateOpenRaidBossGroupVector(builder, __OpenRaidBossGroup);
    }
    var _StackedSeasonRewardGauge = default(VectorOffset);
    if (_o.StackedSeasonRewardGauge != null) {
      var __StackedSeasonRewardGauge = _o.StackedSeasonRewardGauge.ToArray();
      _StackedSeasonRewardGauge = CreateStackedSeasonRewardGaugeVector(builder, __StackedSeasonRewardGauge);
    }
    var _SeasonRewardId = default(VectorOffset);
    if (_o.SeasonRewardId != null) {
      var __SeasonRewardId = _o.SeasonRewardId.ToArray();
      _SeasonRewardId = CreateSeasonRewardIdVector(builder, __SeasonRewardId);
    }
    return CreateRaidSeasonManageExcel(
      builder,
      _o.SeasonId,
      _o.SeasonDisplay,
      _SeasonStartData,
      _SeasonEndData,
      _SettlementEndDate,
      _OpenRaidBossGroup,
      _o.RankingRewardGroupId,
      _o.MaxSeasonRewardGauage,
      _StackedSeasonRewardGauge,
      _SeasonRewardId);
  }
}

public class RaidSeasonManageExcelT
{
  public long SeasonId { get; set; }
  public long SeasonDisplay { get; set; }
  public string SeasonStartData { get; set; }
  public string SeasonEndData { get; set; }
  public string SettlementEndDate { get; set; }
  public List<string> OpenRaidBossGroup { get; set; }
  public long RankingRewardGroupId { get; set; }
  public int MaxSeasonRewardGauage { get; set; }
  public List<long> StackedSeasonRewardGauge { get; set; }
  public List<long> SeasonRewardId { get; set; }

  public RaidSeasonManageExcelT() {
    this.SeasonId = 0;
    this.SeasonDisplay = 0;
    this.SeasonStartData = null;
    this.SeasonEndData = null;
    this.SettlementEndDate = null;
    this.OpenRaidBossGroup = null;
    this.RankingRewardGroupId = 0;
    this.MaxSeasonRewardGauage = 0;
    this.StackedSeasonRewardGauge = null;
    this.SeasonRewardId = null;
  }
}


static public class RaidSeasonManageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonDisplay*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*SeasonStartData*/, false)
      && verifier.VerifyString(tablePos, 10 /*SeasonEndData*/, false)
      && verifier.VerifyString(tablePos, 12 /*SettlementEndDate*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 14 /*OpenRaidBossGroup*/, false)
      && verifier.VerifyField(tablePos, 16 /*RankingRewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*MaxSeasonRewardGauage*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*StackedSeasonRewardGauge*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*SeasonRewardId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
