// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct TutorialFailureImageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TutorialFailureImageExcel GetRootAsTutorialFailureImageExcel(ByteBuffer _bb) { return GetRootAsTutorialFailureImageExcel(_bb, new TutorialFailureImageExcel()); }
  public static TutorialFailureImageExcel GetRootAsTutorialFailureImageExcel(ByteBuffer _bb, TutorialFailureImageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TutorialFailureImageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.TutorialFailureContentType Contents { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.TutorialFailureContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TutorialFailureContentType.None; } }
  public string Type { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTypeArray() { return __p.__vector_as_array<byte>(8); }
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

  public static Offset<SCHALE.Common.FlatData.TutorialFailureImageExcel> CreateTutorialFailureImageExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.TutorialFailureContentType Contents = SCHALE.Common.FlatData.TutorialFailureContentType.None,
      StringOffset TypeOffset = default(StringOffset),
      StringOffset ImagePathKrOffset = default(StringOffset),
      StringOffset ImagePathJpOffset = default(StringOffset)) {
    builder.StartTable(5);
    TutorialFailureImageExcel.AddId(builder, Id);
    TutorialFailureImageExcel.AddImagePathJp(builder, ImagePathJpOffset);
    TutorialFailureImageExcel.AddImagePathKr(builder, ImagePathKrOffset);
    TutorialFailureImageExcel.AddType(builder, TypeOffset);
    TutorialFailureImageExcel.AddContents(builder, Contents);
    return TutorialFailureImageExcel.EndTutorialFailureImageExcel(builder);
  }

  public static void StartTutorialFailureImageExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddContents(FlatBufferBuilder builder, SCHALE.Common.FlatData.TutorialFailureContentType contents) { builder.AddInt(1, (int)contents, 0); }
  public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset) { builder.AddOffset(2, typeOffset.Value, 0); }
  public static void AddImagePathKr(FlatBufferBuilder builder, StringOffset imagePathKrOffset) { builder.AddOffset(3, imagePathKrOffset.Value, 0); }
  public static void AddImagePathJp(FlatBufferBuilder builder, StringOffset imagePathJpOffset) { builder.AddOffset(4, imagePathJpOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.TutorialFailureImageExcel> EndTutorialFailureImageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.TutorialFailureImageExcel>(o);
  }
  public TutorialFailureImageExcelT UnPack() {
    var _o = new TutorialFailureImageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TutorialFailureImageExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("TutorialFailureImage");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Contents = TableEncryptionService.Convert(this.Contents, key);
    _o.Type = TableEncryptionService.Convert(this.Type, key);
    _o.ImagePathKr = TableEncryptionService.Convert(this.ImagePathKr, key);
    _o.ImagePathJp = TableEncryptionService.Convert(this.ImagePathJp, key);
  }
  public static Offset<SCHALE.Common.FlatData.TutorialFailureImageExcel> Pack(FlatBufferBuilder builder, TutorialFailureImageExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.TutorialFailureImageExcel>);
    var _Type = _o.Type == null ? default(StringOffset) : builder.CreateString(_o.Type);
    var _ImagePathKr = _o.ImagePathKr == null ? default(StringOffset) : builder.CreateString(_o.ImagePathKr);
    var _ImagePathJp = _o.ImagePathJp == null ? default(StringOffset) : builder.CreateString(_o.ImagePathJp);
    return CreateTutorialFailureImageExcel(
      builder,
      _o.Id,
      _o.Contents,
      _Type,
      _ImagePathKr,
      _ImagePathJp);
  }
}

public class TutorialFailureImageExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.TutorialFailureContentType Contents { get; set; }
  public string Type { get; set; }
  public string ImagePathKr { get; set; }
  public string ImagePathJp { get; set; }

  public TutorialFailureImageExcelT() {
    this.Id = 0;
    this.Contents = SCHALE.Common.FlatData.TutorialFailureContentType.None;
    this.Type = null;
    this.ImagePathKr = null;
    this.ImagePathJp = null;
  }
}


static public class TutorialFailureImageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Contents*/, 4 /*SCHALE.Common.FlatData.TutorialFailureContentType*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Type*/, false)
      && verifier.VerifyString(tablePos, 10 /*ImagePathKr*/, false)
      && verifier.VerifyString(tablePos, 12 /*ImagePathJp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
