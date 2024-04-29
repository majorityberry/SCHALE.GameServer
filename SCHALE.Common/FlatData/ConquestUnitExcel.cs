// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ConquestUnitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestUnitExcel GetRootAsConquestUnitExcel(ByteBuffer _bb) { return GetRootAsConquestUnitExcel(_bb, new ConquestUnitExcel()); }
  public static ConquestUnitExcel GetRootAsConquestUnitExcel(ByteBuffer _bb, ConquestUnitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestUnitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint Key { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string PrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string StrategyPrefabName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyPrefabNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStrategyPrefabNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStrategyPrefabNameArray() { return __p.__vector_as_array<byte>(12); }
  public float Scale { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ShieldEffectScale { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string UnitFxPrefabName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnitFxPrefabNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetUnitFxPrefabNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetUnitFxPrefabNameArray() { return __p.__vector_as_array<byte>(18); }
  public string PointAnimation { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPointAnimationBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetPointAnimationBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetPointAnimationArray() { return __p.__vector_as_array<byte>(20); }
  public SCHALE.Common.FlatData.ConquestEnemyType EnemyType { get { int o = __p.__offset(22); return o != 0 ? (SCHALE.Common.FlatData.ConquestEnemyType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ConquestEnemyType.None; } }
  public SCHALE.Common.FlatData.ConquestTeamType Team { get { int o = __p.__offset(24); return o != 0 ? (SCHALE.Common.FlatData.ConquestTeamType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ConquestTeamType.None; } }
  public long UnitGroup { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PrevUnitGroup { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StarGoalType StarGoal(int j) { int o = __p.__offset(34); return o != 0 ? (SCHALE.Common.FlatData.StarGoalType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.StarGoalType)0; }
  public int StarGoalLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.StarGoalType> GetStarGoalBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.StarGoalType>(34, 4); }
#else
  public ArraySegment<byte>? GetStarGoalBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public SCHALE.Common.FlatData.StarGoalType[] GetStarGoalArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.StarGoalType[] a = new SCHALE.Common.FlatData.StarGoalType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.StarGoalType)__p.bb.GetInt(p + i * 4); } return a; }
  public int StarGoalAmount(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StarGoalAmountLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStarGoalAmountBytes() { return __p.__vector_as_span<int>(36, 4); }
#else
  public ArraySegment<byte>? GetStarGoalAmountBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public int[] GetStarGoalAmountArray() { return __p.__vector_as_array<int>(36); }
  public long GroupBuffId { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType StageEnterCostType { get { int o = __p.__offset(40); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public SCHALE.Common.FlatData.ParcelType ManageEchelonStageEnterCostType { get { int o = __p.__offset(46); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ManageEchelonStageEnterCostId { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ManageEchelonStageEnterCostAmount { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long EnterScenarioGroupId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearScenarioGroupId { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConquestRewardId { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get { int o = __p.__offset(58); return o != 0 ? (SCHALE.Common.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TacticRewardExp { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(66); return o != 0 ? (SCHALE.Common.FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EchelonExtensionType.Base; } }

  public static Offset<SCHALE.Common.FlatData.ConquestUnitExcel> CreateConquestUnitExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint Key = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset PrefabNameOffset = default(StringOffset),
      StringOffset StrategyPrefabNameOffset = default(StringOffset),
      float Scale = 0.0f,
      float ShieldEffectScale = 0.0f,
      StringOffset UnitFxPrefabNameOffset = default(StringOffset),
      StringOffset PointAnimationOffset = default(StringOffset),
      SCHALE.Common.FlatData.ConquestEnemyType EnemyType = SCHALE.Common.FlatData.ConquestEnemyType.None,
      SCHALE.Common.FlatData.ConquestTeamType Team = SCHALE.Common.FlatData.ConquestTeamType.None,
      long UnitGroup = 0,
      long PrevUnitGroup = 0,
      long BattleDuration = 0,
      long GroundId = 0,
      VectorOffset StarGoalOffset = default(VectorOffset),
      VectorOffset StarGoalAmountOffset = default(VectorOffset),
      long GroupBuffId = 0,
      SCHALE.Common.FlatData.ParcelType StageEnterCostType = SCHALE.Common.FlatData.ParcelType.None,
      long StageEnterCostId = 0,
      int StageEnterCostAmount = 0,
      SCHALE.Common.FlatData.ParcelType ManageEchelonStageEnterCostType = SCHALE.Common.FlatData.ParcelType.None,
      long ManageEchelonStageEnterCostId = 0,
      int ManageEchelonStageEnterCostAmount = 0,
      long EnterScenarioGroupId = 0,
      long ClearScenarioGroupId = 0,
      long ConquestRewardId = 0,
      SCHALE.Common.FlatData.StageTopography StageTopography = SCHALE.Common.FlatData.StageTopography.Street,
      int RecommandLevel = 0,
      long TacticRewardExp = 0,
      long FixedEchelonId = 0,
      SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base) {
    builder.StartTable(32);
    ConquestUnitExcel.AddFixedEchelonId(builder, FixedEchelonId);
    ConquestUnitExcel.AddTacticRewardExp(builder, TacticRewardExp);
    ConquestUnitExcel.AddConquestRewardId(builder, ConquestRewardId);
    ConquestUnitExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupId);
    ConquestUnitExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupId);
    ConquestUnitExcel.AddManageEchelonStageEnterCostId(builder, ManageEchelonStageEnterCostId);
    ConquestUnitExcel.AddStageEnterCostId(builder, StageEnterCostId);
    ConquestUnitExcel.AddGroupBuffId(builder, GroupBuffId);
    ConquestUnitExcel.AddGroundId(builder, GroundId);
    ConquestUnitExcel.AddBattleDuration(builder, BattleDuration);
    ConquestUnitExcel.AddPrevUnitGroup(builder, PrevUnitGroup);
    ConquestUnitExcel.AddUnitGroup(builder, UnitGroup);
    ConquestUnitExcel.AddId(builder, Id);
    ConquestUnitExcel.AddEchelonExtensionType(builder, EchelonExtensionType);
    ConquestUnitExcel.AddRecommandLevel(builder, RecommandLevel);
    ConquestUnitExcel.AddStageTopography(builder, StageTopography);
    ConquestUnitExcel.AddManageEchelonStageEnterCostAmount(builder, ManageEchelonStageEnterCostAmount);
    ConquestUnitExcel.AddManageEchelonStageEnterCostType(builder, ManageEchelonStageEnterCostType);
    ConquestUnitExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    ConquestUnitExcel.AddStageEnterCostType(builder, StageEnterCostType);
    ConquestUnitExcel.AddStarGoalAmount(builder, StarGoalAmountOffset);
    ConquestUnitExcel.AddStarGoal(builder, StarGoalOffset);
    ConquestUnitExcel.AddTeam(builder, Team);
    ConquestUnitExcel.AddEnemyType(builder, EnemyType);
    ConquestUnitExcel.AddPointAnimation(builder, PointAnimationOffset);
    ConquestUnitExcel.AddUnitFxPrefabName(builder, UnitFxPrefabNameOffset);
    ConquestUnitExcel.AddShieldEffectScale(builder, ShieldEffectScale);
    ConquestUnitExcel.AddScale(builder, Scale);
    ConquestUnitExcel.AddStrategyPrefabName(builder, StrategyPrefabNameOffset);
    ConquestUnitExcel.AddPrefabName(builder, PrefabNameOffset);
    ConquestUnitExcel.AddName(builder, NameOffset);
    ConquestUnitExcel.AddKey(builder, Key);
    return ConquestUnitExcel.EndConquestUnitExcel(builder);
  }

  public static void StartConquestUnitExcel(FlatBufferBuilder builder) { builder.StartTable(32); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(1, key, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(3, prefabNameOffset.Value, 0); }
  public static void AddStrategyPrefabName(FlatBufferBuilder builder, StringOffset strategyPrefabNameOffset) { builder.AddOffset(4, strategyPrefabNameOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, float scale) { builder.AddFloat(5, scale, 0.0f); }
  public static void AddShieldEffectScale(FlatBufferBuilder builder, float shieldEffectScale) { builder.AddFloat(6, shieldEffectScale, 0.0f); }
  public static void AddUnitFxPrefabName(FlatBufferBuilder builder, StringOffset unitFxPrefabNameOffset) { builder.AddOffset(7, unitFxPrefabNameOffset.Value, 0); }
  public static void AddPointAnimation(FlatBufferBuilder builder, StringOffset pointAnimationOffset) { builder.AddOffset(8, pointAnimationOffset.Value, 0); }
  public static void AddEnemyType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ConquestEnemyType enemyType) { builder.AddInt(9, (int)enemyType, 0); }
  public static void AddTeam(FlatBufferBuilder builder, SCHALE.Common.FlatData.ConquestTeamType team) { builder.AddInt(10, (int)team, 0); }
  public static void AddUnitGroup(FlatBufferBuilder builder, long unitGroup) { builder.AddLong(11, unitGroup, 0); }
  public static void AddPrevUnitGroup(FlatBufferBuilder builder, long prevUnitGroup) { builder.AddLong(12, prevUnitGroup, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(13, battleDuration, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(14, groundId, 0); }
  public static void AddStarGoal(FlatBufferBuilder builder, VectorOffset starGoalOffset) { builder.AddOffset(15, starGoalOffset.Value, 0); }
  public static VectorOffset CreateStarGoalVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.StarGoalType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.StarGoalType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarGoalAmount(FlatBufferBuilder builder, VectorOffset starGoalAmountOffset) { builder.AddOffset(16, starGoalAmountOffset.Value, 0); }
  public static VectorOffset CreateStarGoalAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroupBuffId(FlatBufferBuilder builder, long groupBuffId) { builder.AddLong(17, groupBuffId, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType stageEnterCostType) { builder.AddInt(18, (int)stageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long stageEnterCostId) { builder.AddLong(19, stageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int stageEnterCostAmount) { builder.AddInt(20, stageEnterCostAmount, 0); }
  public static void AddManageEchelonStageEnterCostType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType manageEchelonStageEnterCostType) { builder.AddInt(21, (int)manageEchelonStageEnterCostType, 0); }
  public static void AddManageEchelonStageEnterCostId(FlatBufferBuilder builder, long manageEchelonStageEnterCostId) { builder.AddLong(22, manageEchelonStageEnterCostId, 0); }
  public static void AddManageEchelonStageEnterCostAmount(FlatBufferBuilder builder, int manageEchelonStageEnterCostAmount) { builder.AddInt(23, manageEchelonStageEnterCostAmount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, long enterScenarioGroupId) { builder.AddLong(24, enterScenarioGroupId, 0); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, long clearScenarioGroupId) { builder.AddLong(25, clearScenarioGroupId, 0); }
  public static void AddConquestRewardId(FlatBufferBuilder builder, long conquestRewardId) { builder.AddLong(26, conquestRewardId, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, SCHALE.Common.FlatData.StageTopography stageTopography) { builder.AddInt(27, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int recommandLevel) { builder.AddInt(28, recommandLevel, 0); }
  public static void AddTacticRewardExp(FlatBufferBuilder builder, long tacticRewardExp) { builder.AddLong(29, tacticRewardExp, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(30, fixedEchelonId, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EchelonExtensionType echelonExtensionType) { builder.AddInt(31, (int)echelonExtensionType, 0); }
  public static Offset<SCHALE.Common.FlatData.ConquestUnitExcel> EndConquestUnitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConquestUnitExcel>(o);
  }
  public ConquestUnitExcelT UnPack() {
    var _o = new ConquestUnitExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestUnitExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConquestUnit");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.PrefabName = TableEncryptionService.Convert(this.PrefabName, key);
    _o.StrategyPrefabName = TableEncryptionService.Convert(this.StrategyPrefabName, key);
    _o.Scale = TableEncryptionService.Convert(this.Scale, key);
    _o.ShieldEffectScale = TableEncryptionService.Convert(this.ShieldEffectScale, key);
    _o.UnitFxPrefabName = TableEncryptionService.Convert(this.UnitFxPrefabName, key);
    _o.PointAnimation = TableEncryptionService.Convert(this.PointAnimation, key);
    _o.EnemyType = TableEncryptionService.Convert(this.EnemyType, key);
    _o.Team = TableEncryptionService.Convert(this.Team, key);
    _o.UnitGroup = TableEncryptionService.Convert(this.UnitGroup, key);
    _o.PrevUnitGroup = TableEncryptionService.Convert(this.PrevUnitGroup, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.StarGoal = new List<SCHALE.Common.FlatData.StarGoalType>();
    for (var _j = 0; _j < this.StarGoalLength; ++_j) {_o.StarGoal.Add(TableEncryptionService.Convert(this.StarGoal(_j), key));}
    _o.StarGoalAmount = new List<int>();
    for (var _j = 0; _j < this.StarGoalAmountLength; ++_j) {_o.StarGoalAmount.Add(TableEncryptionService.Convert(this.StarGoalAmount(_j), key));}
    _o.GroupBuffId = TableEncryptionService.Convert(this.GroupBuffId, key);
    _o.StageEnterCostType = TableEncryptionService.Convert(this.StageEnterCostType, key);
    _o.StageEnterCostId = TableEncryptionService.Convert(this.StageEnterCostId, key);
    _o.StageEnterCostAmount = TableEncryptionService.Convert(this.StageEnterCostAmount, key);
    _o.ManageEchelonStageEnterCostType = TableEncryptionService.Convert(this.ManageEchelonStageEnterCostType, key);
    _o.ManageEchelonStageEnterCostId = TableEncryptionService.Convert(this.ManageEchelonStageEnterCostId, key);
    _o.ManageEchelonStageEnterCostAmount = TableEncryptionService.Convert(this.ManageEchelonStageEnterCostAmount, key);
    _o.EnterScenarioGroupId = TableEncryptionService.Convert(this.EnterScenarioGroupId, key);
    _o.ClearScenarioGroupId = TableEncryptionService.Convert(this.ClearScenarioGroupId, key);
    _o.ConquestRewardId = TableEncryptionService.Convert(this.ConquestRewardId, key);
    _o.StageTopography = TableEncryptionService.Convert(this.StageTopography, key);
    _o.RecommandLevel = TableEncryptionService.Convert(this.RecommandLevel, key);
    _o.TacticRewardExp = TableEncryptionService.Convert(this.TacticRewardExp, key);
    _o.FixedEchelonId = TableEncryptionService.Convert(this.FixedEchelonId, key);
    _o.EchelonExtensionType = TableEncryptionService.Convert(this.EchelonExtensionType, key);
  }
  public static Offset<SCHALE.Common.FlatData.ConquestUnitExcel> Pack(FlatBufferBuilder builder, ConquestUnitExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ConquestUnitExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _PrefabName = _o.PrefabName == null ? default(StringOffset) : builder.CreateString(_o.PrefabName);
    var _StrategyPrefabName = _o.StrategyPrefabName == null ? default(StringOffset) : builder.CreateString(_o.StrategyPrefabName);
    var _UnitFxPrefabName = _o.UnitFxPrefabName == null ? default(StringOffset) : builder.CreateString(_o.UnitFxPrefabName);
    var _PointAnimation = _o.PointAnimation == null ? default(StringOffset) : builder.CreateString(_o.PointAnimation);
    var _StarGoal = default(VectorOffset);
    if (_o.StarGoal != null) {
      var __StarGoal = _o.StarGoal.ToArray();
      _StarGoal = CreateStarGoalVector(builder, __StarGoal);
    }
    var _StarGoalAmount = default(VectorOffset);
    if (_o.StarGoalAmount != null) {
      var __StarGoalAmount = _o.StarGoalAmount.ToArray();
      _StarGoalAmount = CreateStarGoalAmountVector(builder, __StarGoalAmount);
    }
    return CreateConquestUnitExcel(
      builder,
      _o.Id,
      _o.Key,
      _Name,
      _PrefabName,
      _StrategyPrefabName,
      _o.Scale,
      _o.ShieldEffectScale,
      _UnitFxPrefabName,
      _PointAnimation,
      _o.EnemyType,
      _o.Team,
      _o.UnitGroup,
      _o.PrevUnitGroup,
      _o.BattleDuration,
      _o.GroundId,
      _StarGoal,
      _StarGoalAmount,
      _o.GroupBuffId,
      _o.StageEnterCostType,
      _o.StageEnterCostId,
      _o.StageEnterCostAmount,
      _o.ManageEchelonStageEnterCostType,
      _o.ManageEchelonStageEnterCostId,
      _o.ManageEchelonStageEnterCostAmount,
      _o.EnterScenarioGroupId,
      _o.ClearScenarioGroupId,
      _o.ConquestRewardId,
      _o.StageTopography,
      _o.RecommandLevel,
      _o.TacticRewardExp,
      _o.FixedEchelonId,
      _o.EchelonExtensionType);
  }
}

public class ConquestUnitExcelT
{
  public long Id { get; set; }
  public uint Key { get; set; }
  public string Name { get; set; }
  public string PrefabName { get; set; }
  public string StrategyPrefabName { get; set; }
  public float Scale { get; set; }
  public float ShieldEffectScale { get; set; }
  public string UnitFxPrefabName { get; set; }
  public string PointAnimation { get; set; }
  public SCHALE.Common.FlatData.ConquestEnemyType EnemyType { get; set; }
  public SCHALE.Common.FlatData.ConquestTeamType Team { get; set; }
  public long UnitGroup { get; set; }
  public long PrevUnitGroup { get; set; }
  public long BattleDuration { get; set; }
  public long GroundId { get; set; }
  public List<SCHALE.Common.FlatData.StarGoalType> StarGoal { get; set; }
  public List<int> StarGoalAmount { get; set; }
  public long GroupBuffId { get; set; }
  public SCHALE.Common.FlatData.ParcelType StageEnterCostType { get; set; }
  public long StageEnterCostId { get; set; }
  public int StageEnterCostAmount { get; set; }
  public SCHALE.Common.FlatData.ParcelType ManageEchelonStageEnterCostType { get; set; }
  public long ManageEchelonStageEnterCostId { get; set; }
  public int ManageEchelonStageEnterCostAmount { get; set; }
  public long EnterScenarioGroupId { get; set; }
  public long ClearScenarioGroupId { get; set; }
  public long ConquestRewardId { get; set; }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get; set; }
  public int RecommandLevel { get; set; }
  public long TacticRewardExp { get; set; }
  public long FixedEchelonId { get; set; }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get; set; }

  public ConquestUnitExcelT() {
    this.Id = 0;
    this.Key = 0;
    this.Name = null;
    this.PrefabName = null;
    this.StrategyPrefabName = null;
    this.Scale = 0.0f;
    this.ShieldEffectScale = 0.0f;
    this.UnitFxPrefabName = null;
    this.PointAnimation = null;
    this.EnemyType = SCHALE.Common.FlatData.ConquestEnemyType.None;
    this.Team = SCHALE.Common.FlatData.ConquestTeamType.None;
    this.UnitGroup = 0;
    this.PrevUnitGroup = 0;
    this.BattleDuration = 0;
    this.GroundId = 0;
    this.StarGoal = null;
    this.StarGoalAmount = null;
    this.GroupBuffId = 0;
    this.StageEnterCostType = SCHALE.Common.FlatData.ParcelType.None;
    this.StageEnterCostId = 0;
    this.StageEnterCostAmount = 0;
    this.ManageEchelonStageEnterCostType = SCHALE.Common.FlatData.ParcelType.None;
    this.ManageEchelonStageEnterCostId = 0;
    this.ManageEchelonStageEnterCostAmount = 0;
    this.EnterScenarioGroupId = 0;
    this.ClearScenarioGroupId = 0;
    this.ConquestRewardId = 0;
    this.StageTopography = SCHALE.Common.FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.TacticRewardExp = 0;
    this.FixedEchelonId = 0;
    this.EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base;
  }
}


static public class ConquestUnitExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*PrefabName*/, false)
      && verifier.VerifyString(tablePos, 12 /*StrategyPrefabName*/, false)
      && verifier.VerifyField(tablePos, 14 /*Scale*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*ShieldEffectScale*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*UnitFxPrefabName*/, false)
      && verifier.VerifyString(tablePos, 20 /*PointAnimation*/, false)
      && verifier.VerifyField(tablePos, 22 /*EnemyType*/, 4 /*SCHALE.Common.FlatData.ConquestEnemyType*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*Team*/, 4 /*SCHALE.Common.FlatData.ConquestTeamType*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*UnitGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*PrevUnitGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*StarGoal*/, 4 /*SCHALE.Common.FlatData.StarGoalType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*StarGoalAmount*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 38 /*GroupBuffId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*StageEnterCostType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*StageEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*StageEnterCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*ManageEchelonStageEnterCostType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*ManageEchelonStageEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*ManageEchelonStageEnterCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 52 /*EnterScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 54 /*ClearScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 56 /*ConquestRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*StageTopography*/, 4 /*SCHALE.Common.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 60 /*RecommandLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 62 /*TacticRewardExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 64 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 66 /*EchelonExtensionType*/, 4 /*SCHALE.Common.FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
