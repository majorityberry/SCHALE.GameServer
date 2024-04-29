// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ConquestErosionUnitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestErosionUnitExcel GetRootAsConquestErosionUnitExcel(ByteBuffer _bb) { return GetRootAsConquestErosionUnitExcel(_bb, new ConquestErosionUnitExcel()); }
  public static ConquestErosionUnitExcel GetRootAsConquestErosionUnitExcel(ByteBuffer _bb, ConquestErosionUnitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestErosionUnitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long TilePrefabId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MassErosionUnitId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float MassErosionUnitRotationY { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long IndividualErosionUnitId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float IndividualErosionUnitRotationY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.ConquestErosionUnitExcel> CreateConquestErosionUnitExcel(FlatBufferBuilder builder,
      long TilePrefabId = 0,
      long MassErosionUnitId = 0,
      float MassErosionUnitRotationY = 0.0f,
      long IndividualErosionUnitId = 0,
      float IndividualErosionUnitRotationY = 0.0f) {
    builder.StartTable(5);
    ConquestErosionUnitExcel.AddIndividualErosionUnitId(builder, IndividualErosionUnitId);
    ConquestErosionUnitExcel.AddMassErosionUnitId(builder, MassErosionUnitId);
    ConquestErosionUnitExcel.AddTilePrefabId(builder, TilePrefabId);
    ConquestErosionUnitExcel.AddIndividualErosionUnitRotationY(builder, IndividualErosionUnitRotationY);
    ConquestErosionUnitExcel.AddMassErosionUnitRotationY(builder, MassErosionUnitRotationY);
    return ConquestErosionUnitExcel.EndConquestErosionUnitExcel(builder);
  }

  public static void StartConquestErosionUnitExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddTilePrefabId(FlatBufferBuilder builder, long tilePrefabId) { builder.AddLong(0, tilePrefabId, 0); }
  public static void AddMassErosionUnitId(FlatBufferBuilder builder, long massErosionUnitId) { builder.AddLong(1, massErosionUnitId, 0); }
  public static void AddMassErosionUnitRotationY(FlatBufferBuilder builder, float massErosionUnitRotationY) { builder.AddFloat(2, massErosionUnitRotationY, 0.0f); }
  public static void AddIndividualErosionUnitId(FlatBufferBuilder builder, long individualErosionUnitId) { builder.AddLong(3, individualErosionUnitId, 0); }
  public static void AddIndividualErosionUnitRotationY(FlatBufferBuilder builder, float individualErosionUnitRotationY) { builder.AddFloat(4, individualErosionUnitRotationY, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.ConquestErosionUnitExcel> EndConquestErosionUnitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConquestErosionUnitExcel>(o);
  }
  public ConquestErosionUnitExcelT UnPack() {
    var _o = new ConquestErosionUnitExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestErosionUnitExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConquestErosionUnit");
    _o.TilePrefabId = TableEncryptionService.Convert(this.TilePrefabId, key);
    _o.MassErosionUnitId = TableEncryptionService.Convert(this.MassErosionUnitId, key);
    _o.MassErosionUnitRotationY = TableEncryptionService.Convert(this.MassErosionUnitRotationY, key);
    _o.IndividualErosionUnitId = TableEncryptionService.Convert(this.IndividualErosionUnitId, key);
    _o.IndividualErosionUnitRotationY = TableEncryptionService.Convert(this.IndividualErosionUnitRotationY, key);
  }
  public static Offset<SCHALE.Common.FlatData.ConquestErosionUnitExcel> Pack(FlatBufferBuilder builder, ConquestErosionUnitExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ConquestErosionUnitExcel>);
    return CreateConquestErosionUnitExcel(
      builder,
      _o.TilePrefabId,
      _o.MassErosionUnitId,
      _o.MassErosionUnitRotationY,
      _o.IndividualErosionUnitId,
      _o.IndividualErosionUnitRotationY);
  }
}

public class ConquestErosionUnitExcelT
{
  public long TilePrefabId { get; set; }
  public long MassErosionUnitId { get; set; }
  public float MassErosionUnitRotationY { get; set; }
  public long IndividualErosionUnitId { get; set; }
  public float IndividualErosionUnitRotationY { get; set; }

  public ConquestErosionUnitExcelT() {
    this.TilePrefabId = 0;
    this.MassErosionUnitId = 0;
    this.MassErosionUnitRotationY = 0.0f;
    this.IndividualErosionUnitId = 0;
    this.IndividualErosionUnitRotationY = 0.0f;
  }
}


static public class ConquestErosionUnitExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TilePrefabId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*MassErosionUnitId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*MassErosionUnitRotationY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IndividualErosionUnitId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*IndividualErosionUnitRotationY*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
