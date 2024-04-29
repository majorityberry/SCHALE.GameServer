// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ClanChattingEmojiExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ClanChattingEmojiExcel GetRootAsClanChattingEmojiExcel(ByteBuffer _bb) { return GetRootAsClanChattingEmojiExcel(_bb, new ClanChattingEmojiExcel()); }
  public static ClanChattingEmojiExcel GetRootAsClanChattingEmojiExcel(ByteBuffer _bb, ClanChattingEmojiExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanChattingEmojiExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TabGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ImagePathKr { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathKrBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImagePathKrBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImagePathKrArray() { return __p.__vector_as_array<byte>(10); }
  public string ImagePathJp { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathJpBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetImagePathJpBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetImagePathJpArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<SCHALE.Common.FlatData.ClanChattingEmojiExcel> CreateClanChattingEmojiExcel(FlatBufferBuilder builder,
      long Id = 0,
      int TabGroupId = 0,
      int DisplayOrder = 0,
      StringOffset ImagePathKrOffset = default(StringOffset),
      StringOffset ImagePathJpOffset = default(StringOffset)) {
    builder.StartTable(5);
    ClanChattingEmojiExcel.AddId(builder, Id);
    ClanChattingEmojiExcel.AddImagePathJp(builder, ImagePathJpOffset);
    ClanChattingEmojiExcel.AddImagePathKr(builder, ImagePathKrOffset);
    ClanChattingEmojiExcel.AddDisplayOrder(builder, DisplayOrder);
    ClanChattingEmojiExcel.AddTabGroupId(builder, TabGroupId);
    return ClanChattingEmojiExcel.EndClanChattingEmojiExcel(builder);
  }

  public static void StartClanChattingEmojiExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddTabGroupId(FlatBufferBuilder builder, int tabGroupId) { builder.AddInt(1, tabGroupId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int displayOrder) { builder.AddInt(2, displayOrder, 0); }
  public static void AddImagePathKr(FlatBufferBuilder builder, StringOffset imagePathKrOffset) { builder.AddOffset(3, imagePathKrOffset.Value, 0); }
  public static void AddImagePathJp(FlatBufferBuilder builder, StringOffset imagePathJpOffset) { builder.AddOffset(4, imagePathJpOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.ClanChattingEmojiExcel> EndClanChattingEmojiExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ClanChattingEmojiExcel>(o);
  }
  public ClanChattingEmojiExcelT UnPack() {
    var _o = new ClanChattingEmojiExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ClanChattingEmojiExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ClanChattingEmoji");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.TabGroupId = TableEncryptionService.Convert(this.TabGroupId, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.ImagePathKr = TableEncryptionService.Convert(this.ImagePathKr, key);
    _o.ImagePathJp = TableEncryptionService.Convert(this.ImagePathJp, key);
  }
  public static Offset<SCHALE.Common.FlatData.ClanChattingEmojiExcel> Pack(FlatBufferBuilder builder, ClanChattingEmojiExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ClanChattingEmojiExcel>);
    var _ImagePathKr = _o.ImagePathKr == null ? default(StringOffset) : builder.CreateString(_o.ImagePathKr);
    var _ImagePathJp = _o.ImagePathJp == null ? default(StringOffset) : builder.CreateString(_o.ImagePathJp);
    return CreateClanChattingEmojiExcel(
      builder,
      _o.Id,
      _o.TabGroupId,
      _o.DisplayOrder,
      _ImagePathKr,
      _ImagePathJp);
  }
}

public class ClanChattingEmojiExcelT
{
  public long Id { get; set; }
  public int TabGroupId { get; set; }
  public int DisplayOrder { get; set; }
  public string ImagePathKr { get; set; }
  public string ImagePathJp { get; set; }

  public ClanChattingEmojiExcelT() {
    this.Id = 0;
    this.TabGroupId = 0;
    this.DisplayOrder = 0;
    this.ImagePathKr = null;
    this.ImagePathJp = null;
  }
}


static public class ClanChattingEmojiExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*TabGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DisplayOrder*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*ImagePathKr*/, false)
      && verifier.VerifyString(tablePos, 12 /*ImagePathJp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
