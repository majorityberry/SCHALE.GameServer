// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct FurnitureTemplateExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FurnitureTemplateExcel GetRootAsFurnitureTemplateExcel(ByteBuffer _bb) { return GetRootAsFurnitureTemplateExcel(_bb, new FurnitureTemplateExcel()); }
  public static FurnitureTemplateExcel GetRootAsFurnitureTemplateExcel(ByteBuffer _bb, FurnitureTemplateExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FurnitureTemplateExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FurnitureTemplateId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint FunitureTemplateTitle { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string ThumbnailImagePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThumbnailImagePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetThumbnailImagePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetThumbnailImagePathArray() { return __p.__vector_as_array<byte>(8); }
  public string ImagePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<SCHALE.Common.FlatData.FurnitureTemplateExcel> CreateFurnitureTemplateExcel(FlatBufferBuilder builder,
      long FurnitureTemplateId = 0,
      uint FunitureTemplateTitle = 0,
      StringOffset ThumbnailImagePathOffset = default(StringOffset),
      StringOffset ImagePathOffset = default(StringOffset)) {
    builder.StartTable(4);
    FurnitureTemplateExcel.AddFurnitureTemplateId(builder, FurnitureTemplateId);
    FurnitureTemplateExcel.AddImagePath(builder, ImagePathOffset);
    FurnitureTemplateExcel.AddThumbnailImagePath(builder, ThumbnailImagePathOffset);
    FurnitureTemplateExcel.AddFunitureTemplateTitle(builder, FunitureTemplateTitle);
    return FurnitureTemplateExcel.EndFurnitureTemplateExcel(builder);
  }

  public static void StartFurnitureTemplateExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddFurnitureTemplateId(FlatBufferBuilder builder, long furnitureTemplateId) { builder.AddLong(0, furnitureTemplateId, 0); }
  public static void AddFunitureTemplateTitle(FlatBufferBuilder builder, uint funitureTemplateTitle) { builder.AddUint(1, funitureTemplateTitle, 0); }
  public static void AddThumbnailImagePath(FlatBufferBuilder builder, StringOffset thumbnailImagePathOffset) { builder.AddOffset(2, thumbnailImagePathOffset.Value, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset) { builder.AddOffset(3, imagePathOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.FurnitureTemplateExcel> EndFurnitureTemplateExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FurnitureTemplateExcel>(o);
  }
  public FurnitureTemplateExcelT UnPack() {
    var _o = new FurnitureTemplateExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FurnitureTemplateExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FurnitureTemplate");
    _o.FurnitureTemplateId = TableEncryptionService.Convert(this.FurnitureTemplateId, key);
    _o.FunitureTemplateTitle = TableEncryptionService.Convert(this.FunitureTemplateTitle, key);
    _o.ThumbnailImagePath = TableEncryptionService.Convert(this.ThumbnailImagePath, key);
    _o.ImagePath = TableEncryptionService.Convert(this.ImagePath, key);
  }
  public static Offset<SCHALE.Common.FlatData.FurnitureTemplateExcel> Pack(FlatBufferBuilder builder, FurnitureTemplateExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.FurnitureTemplateExcel>);
    var _ThumbnailImagePath = _o.ThumbnailImagePath == null ? default(StringOffset) : builder.CreateString(_o.ThumbnailImagePath);
    var _ImagePath = _o.ImagePath == null ? default(StringOffset) : builder.CreateString(_o.ImagePath);
    return CreateFurnitureTemplateExcel(
      builder,
      _o.FurnitureTemplateId,
      _o.FunitureTemplateTitle,
      _ThumbnailImagePath,
      _ImagePath);
  }
}

public class FurnitureTemplateExcelT
{
  public long FurnitureTemplateId { get; set; }
  public uint FunitureTemplateTitle { get; set; }
  public string ThumbnailImagePath { get; set; }
  public string ImagePath { get; set; }

  public FurnitureTemplateExcelT() {
    this.FurnitureTemplateId = 0;
    this.FunitureTemplateTitle = 0;
    this.ThumbnailImagePath = null;
    this.ImagePath = null;
  }
}


static public class FurnitureTemplateExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*FurnitureTemplateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FunitureTemplateTitle*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*ThumbnailImagePath*/, false)
      && verifier.VerifyString(tablePos, 10 /*ImagePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
