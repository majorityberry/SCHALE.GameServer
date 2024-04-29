// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct SpineLipsyncExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static SpineLipsyncExcel GetRootAsSpineLipsyncExcel(ByteBuffer _bb) { return GetRootAsSpineLipsyncExcel(_bb, new SpineLipsyncExcel()); }
  public static SpineLipsyncExcel GetRootAsSpineLipsyncExcel(ByteBuffer _bb, SpineLipsyncExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SpineLipsyncExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint VoiceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string AnimJson { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimJsonBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetAnimJsonBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAnimJsonArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<SCHALE.Common.FlatData.SpineLipsyncExcel> CreateSpineLipsyncExcel(FlatBufferBuilder builder,
      uint VoiceId = 0,
      StringOffset AnimJsonOffset = default(StringOffset)) {
    builder.StartTable(2);
    SpineLipsyncExcel.AddAnimJson(builder, AnimJsonOffset);
    SpineLipsyncExcel.AddVoiceId(builder, VoiceId);
    return SpineLipsyncExcel.EndSpineLipsyncExcel(builder);
  }

  public static void StartSpineLipsyncExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint voiceId) { builder.AddUint(0, voiceId, 0); }
  public static void AddAnimJson(FlatBufferBuilder builder, StringOffset animJsonOffset) { builder.AddOffset(1, animJsonOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.SpineLipsyncExcel> EndSpineLipsyncExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.SpineLipsyncExcel>(o);
  }
  public SpineLipsyncExcelT UnPack() {
    var _o = new SpineLipsyncExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SpineLipsyncExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("SpineLipsync");
    _o.VoiceId = TableEncryptionService.Convert(this.VoiceId, key);
    _o.AnimJson = TableEncryptionService.Convert(this.AnimJson, key);
  }
  public static Offset<SCHALE.Common.FlatData.SpineLipsyncExcel> Pack(FlatBufferBuilder builder, SpineLipsyncExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.SpineLipsyncExcel>);
    var _AnimJson = _o.AnimJson == null ? default(StringOffset) : builder.CreateString(_o.AnimJson);
    return CreateSpineLipsyncExcel(
      builder,
      _o.VoiceId,
      _AnimJson);
  }
}

public class SpineLipsyncExcelT
{
  public uint VoiceId { get; set; }
  public string AnimJson { get; set; }

  public SpineLipsyncExcelT() {
    this.VoiceId = 0;
    this.AnimJson = null;
  }
}


static public class SpineLipsyncExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*VoiceId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*AnimJson*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
