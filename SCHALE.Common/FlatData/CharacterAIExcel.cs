// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct CharacterAIExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterAIExcel GetRootAsCharacterAIExcel(ByteBuffer _bb) { return GetRootAsCharacterAIExcel(_bb, new CharacterAIExcel()); }
  public static CharacterAIExcel GetRootAsCharacterAIExcel(ByteBuffer _bb, CharacterAIExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterAIExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EngageType EngageType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.EngageType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EngageType.SearchAndMove; } }
  public SCHALE.Common.FlatData.PositioningType Positioning { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.PositioningType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.PositioningType.CloseToObstacle; } }
  public bool CheckCanUseAutoSkill { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long DistanceReduceRatioObstaclePath { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceObstaclePath { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceRatioFormationPath { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DistanceReduceFormationPath { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MinimumPositionGap { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CanUseObstacleOfKneelMotion { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool CanUseObstacleOfStandMotion { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool HasTargetSwitchingMotion { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.CharacterAIExcel> CreateCharacterAIExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.EngageType EngageType = SCHALE.Common.FlatData.EngageType.SearchAndMove,
      SCHALE.Common.FlatData.PositioningType Positioning = SCHALE.Common.FlatData.PositioningType.CloseToObstacle,
      bool CheckCanUseAutoSkill = false,
      long DistanceReduceRatioObstaclePath = 0,
      long DistanceReduceObstaclePath = 0,
      long DistanceReduceRatioFormationPath = 0,
      long DistanceReduceFormationPath = 0,
      long MinimumPositionGap = 0,
      bool CanUseObstacleOfKneelMotion = false,
      bool CanUseObstacleOfStandMotion = false,
      bool HasTargetSwitchingMotion = false) {
    builder.StartTable(12);
    CharacterAIExcel.AddMinimumPositionGap(builder, MinimumPositionGap);
    CharacterAIExcel.AddDistanceReduceFormationPath(builder, DistanceReduceFormationPath);
    CharacterAIExcel.AddDistanceReduceRatioFormationPath(builder, DistanceReduceRatioFormationPath);
    CharacterAIExcel.AddDistanceReduceObstaclePath(builder, DistanceReduceObstaclePath);
    CharacterAIExcel.AddDistanceReduceRatioObstaclePath(builder, DistanceReduceRatioObstaclePath);
    CharacterAIExcel.AddId(builder, Id);
    CharacterAIExcel.AddPositioning(builder, Positioning);
    CharacterAIExcel.AddEngageType(builder, EngageType);
    CharacterAIExcel.AddHasTargetSwitchingMotion(builder, HasTargetSwitchingMotion);
    CharacterAIExcel.AddCanUseObstacleOfStandMotion(builder, CanUseObstacleOfStandMotion);
    CharacterAIExcel.AddCanUseObstacleOfKneelMotion(builder, CanUseObstacleOfKneelMotion);
    CharacterAIExcel.AddCheckCanUseAutoSkill(builder, CheckCanUseAutoSkill);
    return CharacterAIExcel.EndCharacterAIExcel(builder);
  }

  public static void StartCharacterAIExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEngageType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EngageType engageType) { builder.AddInt(1, (int)engageType, 0); }
  public static void AddPositioning(FlatBufferBuilder builder, SCHALE.Common.FlatData.PositioningType positioning) { builder.AddInt(2, (int)positioning, 0); }
  public static void AddCheckCanUseAutoSkill(FlatBufferBuilder builder, bool checkCanUseAutoSkill) { builder.AddBool(3, checkCanUseAutoSkill, false); }
  public static void AddDistanceReduceRatioObstaclePath(FlatBufferBuilder builder, long distanceReduceRatioObstaclePath) { builder.AddLong(4, distanceReduceRatioObstaclePath, 0); }
  public static void AddDistanceReduceObstaclePath(FlatBufferBuilder builder, long distanceReduceObstaclePath) { builder.AddLong(5, distanceReduceObstaclePath, 0); }
  public static void AddDistanceReduceRatioFormationPath(FlatBufferBuilder builder, long distanceReduceRatioFormationPath) { builder.AddLong(6, distanceReduceRatioFormationPath, 0); }
  public static void AddDistanceReduceFormationPath(FlatBufferBuilder builder, long distanceReduceFormationPath) { builder.AddLong(7, distanceReduceFormationPath, 0); }
  public static void AddMinimumPositionGap(FlatBufferBuilder builder, long minimumPositionGap) { builder.AddLong(8, minimumPositionGap, 0); }
  public static void AddCanUseObstacleOfKneelMotion(FlatBufferBuilder builder, bool canUseObstacleOfKneelMotion) { builder.AddBool(9, canUseObstacleOfKneelMotion, false); }
  public static void AddCanUseObstacleOfStandMotion(FlatBufferBuilder builder, bool canUseObstacleOfStandMotion) { builder.AddBool(10, canUseObstacleOfStandMotion, false); }
  public static void AddHasTargetSwitchingMotion(FlatBufferBuilder builder, bool hasTargetSwitchingMotion) { builder.AddBool(11, hasTargetSwitchingMotion, false); }
  public static Offset<SCHALE.Common.FlatData.CharacterAIExcel> EndCharacterAIExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterAIExcel>(o);
  }
  public CharacterAIExcelT UnPack() {
    var _o = new CharacterAIExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterAIExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterAI");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.EngageType = TableEncryptionService.Convert(this.EngageType, key);
    _o.Positioning = TableEncryptionService.Convert(this.Positioning, key);
    _o.CheckCanUseAutoSkill = TableEncryptionService.Convert(this.CheckCanUseAutoSkill, key);
    _o.DistanceReduceRatioObstaclePath = TableEncryptionService.Convert(this.DistanceReduceRatioObstaclePath, key);
    _o.DistanceReduceObstaclePath = TableEncryptionService.Convert(this.DistanceReduceObstaclePath, key);
    _o.DistanceReduceRatioFormationPath = TableEncryptionService.Convert(this.DistanceReduceRatioFormationPath, key);
    _o.DistanceReduceFormationPath = TableEncryptionService.Convert(this.DistanceReduceFormationPath, key);
    _o.MinimumPositionGap = TableEncryptionService.Convert(this.MinimumPositionGap, key);
    _o.CanUseObstacleOfKneelMotion = TableEncryptionService.Convert(this.CanUseObstacleOfKneelMotion, key);
    _o.CanUseObstacleOfStandMotion = TableEncryptionService.Convert(this.CanUseObstacleOfStandMotion, key);
    _o.HasTargetSwitchingMotion = TableEncryptionService.Convert(this.HasTargetSwitchingMotion, key);
  }
  public static Offset<SCHALE.Common.FlatData.CharacterAIExcel> Pack(FlatBufferBuilder builder, CharacterAIExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.CharacterAIExcel>);
    return CreateCharacterAIExcel(
      builder,
      _o.Id,
      _o.EngageType,
      _o.Positioning,
      _o.CheckCanUseAutoSkill,
      _o.DistanceReduceRatioObstaclePath,
      _o.DistanceReduceObstaclePath,
      _o.DistanceReduceRatioFormationPath,
      _o.DistanceReduceFormationPath,
      _o.MinimumPositionGap,
      _o.CanUseObstacleOfKneelMotion,
      _o.CanUseObstacleOfStandMotion,
      _o.HasTargetSwitchingMotion);
  }
}

public class CharacterAIExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.EngageType EngageType { get; set; }
  public SCHALE.Common.FlatData.PositioningType Positioning { get; set; }
  public bool CheckCanUseAutoSkill { get; set; }
  public long DistanceReduceRatioObstaclePath { get; set; }
  public long DistanceReduceObstaclePath { get; set; }
  public long DistanceReduceRatioFormationPath { get; set; }
  public long DistanceReduceFormationPath { get; set; }
  public long MinimumPositionGap { get; set; }
  public bool CanUseObstacleOfKneelMotion { get; set; }
  public bool CanUseObstacleOfStandMotion { get; set; }
  public bool HasTargetSwitchingMotion { get; set; }

  public CharacterAIExcelT() {
    this.Id = 0;
    this.EngageType = SCHALE.Common.FlatData.EngageType.SearchAndMove;
    this.Positioning = SCHALE.Common.FlatData.PositioningType.CloseToObstacle;
    this.CheckCanUseAutoSkill = false;
    this.DistanceReduceRatioObstaclePath = 0;
    this.DistanceReduceObstaclePath = 0;
    this.DistanceReduceRatioFormationPath = 0;
    this.DistanceReduceFormationPath = 0;
    this.MinimumPositionGap = 0;
    this.CanUseObstacleOfKneelMotion = false;
    this.CanUseObstacleOfStandMotion = false;
    this.HasTargetSwitchingMotion = false;
  }
}


static public class CharacterAIExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EngageType*/, 4 /*SCHALE.Common.FlatData.EngageType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Positioning*/, 4 /*SCHALE.Common.FlatData.PositioningType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*CheckCanUseAutoSkill*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*DistanceReduceRatioObstaclePath*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*DistanceReduceObstaclePath*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*DistanceReduceRatioFormationPath*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*DistanceReduceFormationPath*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*MinimumPositionGap*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*CanUseObstacleOfKneelMotion*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 24 /*CanUseObstacleOfStandMotion*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 26 /*HasTargetSwitchingMotion*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
