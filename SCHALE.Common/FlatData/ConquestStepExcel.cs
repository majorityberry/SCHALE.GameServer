// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ConquestStepExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb) { return GetRootAsConquestStepExcel(_bb, new ConquestStepExcel()); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb, ConquestStepExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestStepExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StageDifficulty MapDifficulty { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StageDifficulty.None; } }
  public int Step { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string StepGoalLocalize { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepGoalLocalizeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStepGoalLocalizeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStepGoalLocalizeArray() { return __p.__vector_as_array<byte>(10); }
  public long StepEnterScenarioGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType StepEnterItemType { get { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long StepEnterItemUniqueId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StepEnterItemAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UnexpectedEventUnitId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int UnexpectedEventUnitIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetUnexpectedEventUnitIdArray() { return __p.__vector_as_array<long>(20); }
  public string UnexpectedEventPrefab { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnexpectedEventPrefabBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetUnexpectedEventPrefabBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetUnexpectedEventPrefabArray() { return __p.__vector_as_array<byte>(22); }
  public long TreasureBoxObjectId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TreasureBoxCountPerStepOpen { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.ConquestStepExcel> CreateConquestStepExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      SCHALE.Common.FlatData.StageDifficulty MapDifficulty = SCHALE.Common.FlatData.StageDifficulty.None,
      int Step = 0,
      StringOffset StepGoalLocalizeOffset = default(StringOffset),
      long StepEnterScenarioGroupId = 0,
      SCHALE.Common.FlatData.ParcelType StepEnterItemType = SCHALE.Common.FlatData.ParcelType.None,
      long StepEnterItemUniqueId = 0,
      long StepEnterItemAmount = 0,
      VectorOffset UnexpectedEventUnitIdOffset = default(VectorOffset),
      StringOffset UnexpectedEventPrefabOffset = default(StringOffset),
      long TreasureBoxObjectId = 0,
      int TreasureBoxCountPerStepOpen = 0) {
    builder.StartTable(12);
    ConquestStepExcel.AddTreasureBoxObjectId(builder, TreasureBoxObjectId);
    ConquestStepExcel.AddStepEnterItemAmount(builder, StepEnterItemAmount);
    ConquestStepExcel.AddStepEnterItemUniqueId(builder, StepEnterItemUniqueId);
    ConquestStepExcel.AddStepEnterScenarioGroupId(builder, StepEnterScenarioGroupId);
    ConquestStepExcel.AddEventContentId(builder, EventContentId);
    ConquestStepExcel.AddTreasureBoxCountPerStepOpen(builder, TreasureBoxCountPerStepOpen);
    ConquestStepExcel.AddUnexpectedEventPrefab(builder, UnexpectedEventPrefabOffset);
    ConquestStepExcel.AddUnexpectedEventUnitId(builder, UnexpectedEventUnitIdOffset);
    ConquestStepExcel.AddStepEnterItemType(builder, StepEnterItemType);
    ConquestStepExcel.AddStepGoalLocalize(builder, StepGoalLocalizeOffset);
    ConquestStepExcel.AddStep(builder, Step);
    ConquestStepExcel.AddMapDifficulty(builder, MapDifficulty);
    return ConquestStepExcel.EndConquestStepExcel(builder);
  }

  public static void StartConquestStepExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, SCHALE.Common.FlatData.StageDifficulty mapDifficulty) { builder.AddInt(1, (int)mapDifficulty, 0); }
  public static void AddStep(FlatBufferBuilder builder, int step) { builder.AddInt(2, step, 0); }
  public static void AddStepGoalLocalize(FlatBufferBuilder builder, StringOffset stepGoalLocalizeOffset) { builder.AddOffset(3, stepGoalLocalizeOffset.Value, 0); }
  public static void AddStepEnterScenarioGroupId(FlatBufferBuilder builder, long stepEnterScenarioGroupId) { builder.AddLong(4, stepEnterScenarioGroupId, 0); }
  public static void AddStepEnterItemType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType stepEnterItemType) { builder.AddInt(5, (int)stepEnterItemType, 0); }
  public static void AddStepEnterItemUniqueId(FlatBufferBuilder builder, long stepEnterItemUniqueId) { builder.AddLong(6, stepEnterItemUniqueId, 0); }
  public static void AddStepEnterItemAmount(FlatBufferBuilder builder, long stepEnterItemAmount) { builder.AddLong(7, stepEnterItemAmount, 0); }
  public static void AddUnexpectedEventUnitId(FlatBufferBuilder builder, VectorOffset unexpectedEventUnitIdOffset) { builder.AddOffset(8, unexpectedEventUnitIdOffset.Value, 0); }
  public static VectorOffset CreateUnexpectedEventUnitIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnexpectedEventUnitIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddUnexpectedEventPrefab(FlatBufferBuilder builder, StringOffset unexpectedEventPrefabOffset) { builder.AddOffset(9, unexpectedEventPrefabOffset.Value, 0); }
  public static void AddTreasureBoxObjectId(FlatBufferBuilder builder, long treasureBoxObjectId) { builder.AddLong(10, treasureBoxObjectId, 0); }
  public static void AddTreasureBoxCountPerStepOpen(FlatBufferBuilder builder, int treasureBoxCountPerStepOpen) { builder.AddInt(11, treasureBoxCountPerStepOpen, 0); }
  public static Offset<SCHALE.Common.FlatData.ConquestStepExcel> EndConquestStepExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConquestStepExcel>(o);
  }
  public ConquestStepExcelT UnPack() {
    var _o = new ConquestStepExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestStepExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConquestStep");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.MapDifficulty = TableEncryptionService.Convert(this.MapDifficulty, key);
    _o.Step = TableEncryptionService.Convert(this.Step, key);
    _o.StepGoalLocalize = TableEncryptionService.Convert(this.StepGoalLocalize, key);
    _o.StepEnterScenarioGroupId = TableEncryptionService.Convert(this.StepEnterScenarioGroupId, key);
    _o.StepEnterItemType = TableEncryptionService.Convert(this.StepEnterItemType, key);
    _o.StepEnterItemUniqueId = TableEncryptionService.Convert(this.StepEnterItemUniqueId, key);
    _o.StepEnterItemAmount = TableEncryptionService.Convert(this.StepEnterItemAmount, key);
    _o.UnexpectedEventUnitId = new List<long>();
    for (var _j = 0; _j < this.UnexpectedEventUnitIdLength; ++_j) {_o.UnexpectedEventUnitId.Add(TableEncryptionService.Convert(this.UnexpectedEventUnitId(_j), key));}
    _o.UnexpectedEventPrefab = TableEncryptionService.Convert(this.UnexpectedEventPrefab, key);
    _o.TreasureBoxObjectId = TableEncryptionService.Convert(this.TreasureBoxObjectId, key);
    _o.TreasureBoxCountPerStepOpen = TableEncryptionService.Convert(this.TreasureBoxCountPerStepOpen, key);
  }
  public static Offset<SCHALE.Common.FlatData.ConquestStepExcel> Pack(FlatBufferBuilder builder, ConquestStepExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ConquestStepExcel>);
    var _StepGoalLocalize = _o.StepGoalLocalize == null ? default(StringOffset) : builder.CreateString(_o.StepGoalLocalize);
    var _UnexpectedEventUnitId = default(VectorOffset);
    if (_o.UnexpectedEventUnitId != null) {
      var __UnexpectedEventUnitId = _o.UnexpectedEventUnitId.ToArray();
      _UnexpectedEventUnitId = CreateUnexpectedEventUnitIdVector(builder, __UnexpectedEventUnitId);
    }
    var _UnexpectedEventPrefab = _o.UnexpectedEventPrefab == null ? default(StringOffset) : builder.CreateString(_o.UnexpectedEventPrefab);
    return CreateConquestStepExcel(
      builder,
      _o.EventContentId,
      _o.MapDifficulty,
      _o.Step,
      _StepGoalLocalize,
      _o.StepEnterScenarioGroupId,
      _o.StepEnterItemType,
      _o.StepEnterItemUniqueId,
      _o.StepEnterItemAmount,
      _UnexpectedEventUnitId,
      _UnexpectedEventPrefab,
      _o.TreasureBoxObjectId,
      _o.TreasureBoxCountPerStepOpen);
  }
}

public class ConquestStepExcelT
{
  public long EventContentId { get; set; }
  public SCHALE.Common.FlatData.StageDifficulty MapDifficulty { get; set; }
  public int Step { get; set; }
  public string StepGoalLocalize { get; set; }
  public long StepEnterScenarioGroupId { get; set; }
  public SCHALE.Common.FlatData.ParcelType StepEnterItemType { get; set; }
  public long StepEnterItemUniqueId { get; set; }
  public long StepEnterItemAmount { get; set; }
  public List<long> UnexpectedEventUnitId { get; set; }
  public string UnexpectedEventPrefab { get; set; }
  public long TreasureBoxObjectId { get; set; }
  public int TreasureBoxCountPerStepOpen { get; set; }

  public ConquestStepExcelT() {
    this.EventContentId = 0;
    this.MapDifficulty = SCHALE.Common.FlatData.StageDifficulty.None;
    this.Step = 0;
    this.StepGoalLocalize = null;
    this.StepEnterScenarioGroupId = 0;
    this.StepEnterItemType = SCHALE.Common.FlatData.ParcelType.None;
    this.StepEnterItemUniqueId = 0;
    this.StepEnterItemAmount = 0;
    this.UnexpectedEventUnitId = null;
    this.UnexpectedEventPrefab = null;
    this.TreasureBoxObjectId = 0;
    this.TreasureBoxCountPerStepOpen = 0;
  }
}


static public class ConquestStepExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*MapDifficulty*/, 4 /*SCHALE.Common.FlatData.StageDifficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Step*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*StepGoalLocalize*/, false)
      && verifier.VerifyField(tablePos, 12 /*StepEnterScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*StepEnterItemType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*StepEnterItemUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*StepEnterItemAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*UnexpectedEventUnitId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 22 /*UnexpectedEventPrefab*/, false)
      && verifier.VerifyField(tablePos, 24 /*TreasureBoxObjectId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*TreasureBoxCountPerStepOpen*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
