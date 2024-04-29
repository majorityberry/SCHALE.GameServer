// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct MiniGameRhythmBgmExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameRhythmBgmExcel GetRootAsMiniGameRhythmBgmExcel(ByteBuffer _bb) { return GetRootAsMiniGameRhythmBgmExcel(_bb, new MiniGameRhythmBgmExcel()); }
  public static MiniGameRhythmBgmExcel GetRootAsMiniGameRhythmBgmExcel(ByteBuffer _bb, MiniGameRhythmBgmExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameRhythmBgmExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long RhythmBgmId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StageSelectImagePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageSelectImagePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStageSelectImagePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStageSelectImagePathArray() { return __p.__vector_as_array<byte>(8); }
  public long Bpm { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Bgm { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BgmNameText { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmNameTextBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetBgmNameTextBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetBgmNameTextArray() { return __p.__vector_as_array<byte>(14); }
  public string BgmArtistText { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmArtistTextBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetBgmArtistTextBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetBgmArtistTextArray() { return __p.__vector_as_array<byte>(16); }
  public bool HasLyricist { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string BgmComposerText { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmComposerTextBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetBgmComposerTextBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetBgmComposerTextArray() { return __p.__vector_as_array<byte>(20); }
  public int BgmLength { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.MiniGameRhythmBgmExcel> CreateMiniGameRhythmBgmExcel(FlatBufferBuilder builder,
      long RhythmBgmId = 0,
      long EventContentId = 0,
      StringOffset StageSelectImagePathOffset = default(StringOffset),
      long Bpm = 0,
      long Bgm = 0,
      StringOffset BgmNameTextOffset = default(StringOffset),
      StringOffset BgmArtistTextOffset = default(StringOffset),
      bool HasLyricist = false,
      StringOffset BgmComposerTextOffset = default(StringOffset),
      int BgmLength = 0) {
    builder.StartTable(10);
    MiniGameRhythmBgmExcel.AddBgm(builder, Bgm);
    MiniGameRhythmBgmExcel.AddBpm(builder, Bpm);
    MiniGameRhythmBgmExcel.AddEventContentId(builder, EventContentId);
    MiniGameRhythmBgmExcel.AddRhythmBgmId(builder, RhythmBgmId);
    MiniGameRhythmBgmExcel.AddBgmLength(builder, BgmLength);
    MiniGameRhythmBgmExcel.AddBgmComposerText(builder, BgmComposerTextOffset);
    MiniGameRhythmBgmExcel.AddBgmArtistText(builder, BgmArtistTextOffset);
    MiniGameRhythmBgmExcel.AddBgmNameText(builder, BgmNameTextOffset);
    MiniGameRhythmBgmExcel.AddStageSelectImagePath(builder, StageSelectImagePathOffset);
    MiniGameRhythmBgmExcel.AddHasLyricist(builder, HasLyricist);
    return MiniGameRhythmBgmExcel.EndMiniGameRhythmBgmExcel(builder);
  }

  public static void StartMiniGameRhythmBgmExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddRhythmBgmId(FlatBufferBuilder builder, long rhythmBgmId) { builder.AddLong(0, rhythmBgmId, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddStageSelectImagePath(FlatBufferBuilder builder, StringOffset stageSelectImagePathOffset) { builder.AddOffset(2, stageSelectImagePathOffset.Value, 0); }
  public static void AddBpm(FlatBufferBuilder builder, long bpm) { builder.AddLong(3, bpm, 0); }
  public static void AddBgm(FlatBufferBuilder builder, long bgm) { builder.AddLong(4, bgm, 0); }
  public static void AddBgmNameText(FlatBufferBuilder builder, StringOffset bgmNameTextOffset) { builder.AddOffset(5, bgmNameTextOffset.Value, 0); }
  public static void AddBgmArtistText(FlatBufferBuilder builder, StringOffset bgmArtistTextOffset) { builder.AddOffset(6, bgmArtistTextOffset.Value, 0); }
  public static void AddHasLyricist(FlatBufferBuilder builder, bool hasLyricist) { builder.AddBool(7, hasLyricist, false); }
  public static void AddBgmComposerText(FlatBufferBuilder builder, StringOffset bgmComposerTextOffset) { builder.AddOffset(8, bgmComposerTextOffset.Value, 0); }
  public static void AddBgmLength(FlatBufferBuilder builder, int bgmLength) { builder.AddInt(9, bgmLength, 0); }
  public static Offset<SCHALE.Common.FlatData.MiniGameRhythmBgmExcel> EndMiniGameRhythmBgmExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MiniGameRhythmBgmExcel>(o);
  }
  public MiniGameRhythmBgmExcelT UnPack() {
    var _o = new MiniGameRhythmBgmExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameRhythmBgmExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("MiniGameRhythmBgm");
    _o.RhythmBgmId = TableEncryptionService.Convert(this.RhythmBgmId, key);
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.StageSelectImagePath = TableEncryptionService.Convert(this.StageSelectImagePath, key);
    _o.Bpm = TableEncryptionService.Convert(this.Bpm, key);
    _o.Bgm = TableEncryptionService.Convert(this.Bgm, key);
    _o.BgmNameText = TableEncryptionService.Convert(this.BgmNameText, key);
    _o.BgmArtistText = TableEncryptionService.Convert(this.BgmArtistText, key);
    _o.HasLyricist = TableEncryptionService.Convert(this.HasLyricist, key);
    _o.BgmComposerText = TableEncryptionService.Convert(this.BgmComposerText, key);
    _o.BgmLength = TableEncryptionService.Convert(this.BgmLength, key);
  }
  public static Offset<SCHALE.Common.FlatData.MiniGameRhythmBgmExcel> Pack(FlatBufferBuilder builder, MiniGameRhythmBgmExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.MiniGameRhythmBgmExcel>);
    var _StageSelectImagePath = _o.StageSelectImagePath == null ? default(StringOffset) : builder.CreateString(_o.StageSelectImagePath);
    var _BgmNameText = _o.BgmNameText == null ? default(StringOffset) : builder.CreateString(_o.BgmNameText);
    var _BgmArtistText = _o.BgmArtistText == null ? default(StringOffset) : builder.CreateString(_o.BgmArtistText);
    var _BgmComposerText = _o.BgmComposerText == null ? default(StringOffset) : builder.CreateString(_o.BgmComposerText);
    return CreateMiniGameRhythmBgmExcel(
      builder,
      _o.RhythmBgmId,
      _o.EventContentId,
      _StageSelectImagePath,
      _o.Bpm,
      _o.Bgm,
      _BgmNameText,
      _BgmArtistText,
      _o.HasLyricist,
      _BgmComposerText,
      _o.BgmLength);
  }
}

public class MiniGameRhythmBgmExcelT
{
  public long RhythmBgmId { get; set; }
  public long EventContentId { get; set; }
  public string StageSelectImagePath { get; set; }
  public long Bpm { get; set; }
  public long Bgm { get; set; }
  public string BgmNameText { get; set; }
  public string BgmArtistText { get; set; }
  public bool HasLyricist { get; set; }
  public string BgmComposerText { get; set; }
  public int BgmLength { get; set; }

  public MiniGameRhythmBgmExcelT() {
    this.RhythmBgmId = 0;
    this.EventContentId = 0;
    this.StageSelectImagePath = null;
    this.Bpm = 0;
    this.Bgm = 0;
    this.BgmNameText = null;
    this.BgmArtistText = null;
    this.HasLyricist = false;
    this.BgmComposerText = null;
    this.BgmLength = 0;
  }
}


static public class MiniGameRhythmBgmExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*RhythmBgmId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*StageSelectImagePath*/, false)
      && verifier.VerifyField(tablePos, 10 /*Bpm*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*Bgm*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 14 /*BgmNameText*/, false)
      && verifier.VerifyString(tablePos, 16 /*BgmArtistText*/, false)
      && verifier.VerifyField(tablePos, 18 /*HasLyricist*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 20 /*BgmComposerText*/, false)
      && verifier.VerifyField(tablePos, 22 /*BgmLength*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
