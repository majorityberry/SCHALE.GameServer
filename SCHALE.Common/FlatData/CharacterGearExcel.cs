// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct CharacterGearExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterGearExcel GetRootAsCharacterGearExcel(ByteBuffer _bb) { return GetRootAsCharacterGearExcel(_bb, new CharacterGearExcel()); }
  public static CharacterGearExcel GetRootAsCharacterGearExcel(ByteBuffer _bb, CharacterGearExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterGearExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StatLevelUpType.Standard; } }
  public long Tier { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextTierEquipment { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenFavorLevel { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LearnSkillSlot { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLearnSkillSlotBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetLearnSkillSlotBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetLearnSkillSlotArray() { return __p.__vector_as_array<byte>(20); }
  public SCHALE.Common.FlatData.EquipmentOptionType StatType(int j) { int o = __p.__offset(22); return o != 0 ? (SCHALE.Common.FlatData.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.EquipmentOptionType>(22, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public SCHALE.Common.FlatData.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.EquipmentOptionType[] a = new SCHALE.Common.FlatData.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MinStatValue(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MinStatValueLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMinStatValueBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetMinStatValueBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetMinStatValueArray() { return __p.__vector_as_array<long>(24); }
  public long MaxStatValue(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MaxStatValueLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMaxStatValueBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetMaxStatValueBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetMaxStatValueArray() { return __p.__vector_as_array<long>(26); }
  public string Icon { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(28); }
  public uint LocalizeEtcId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public SCHALE.Common.FlatData.Tag Tags(int j) { int o = __p.__offset(32); return o != 0 ? (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.Tag> GetTagsBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.Tag>(32, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public SCHALE.Common.FlatData.Tag[] GetTagsArray() { int o = __p.__offset(32); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.Tag[] a = new SCHALE.Common.FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }

  public static Offset<SCHALE.Common.FlatData.CharacterGearExcel> CreateCharacterGearExcel(FlatBufferBuilder builder,
      long Id = 0,
      long CharacterId = 0,
      SCHALE.Common.FlatData.StatLevelUpType StatLevelUpType = SCHALE.Common.FlatData.StatLevelUpType.Standard,
      long Tier = 0,
      long NextTierEquipment = 0,
      long RecipeId = 0,
      long OpenFavorLevel = 0,
      long MaxLevel = 0,
      StringOffset LearnSkillSlotOffset = default(StringOffset),
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset MinStatValueOffset = default(VectorOffset),
      VectorOffset MaxStatValueOffset = default(VectorOffset),
      StringOffset IconOffset = default(StringOffset),
      uint LocalizeEtcId = 0,
      VectorOffset TagsOffset = default(VectorOffset)) {
    builder.StartTable(15);
    CharacterGearExcel.AddMaxLevel(builder, MaxLevel);
    CharacterGearExcel.AddOpenFavorLevel(builder, OpenFavorLevel);
    CharacterGearExcel.AddRecipeId(builder, RecipeId);
    CharacterGearExcel.AddNextTierEquipment(builder, NextTierEquipment);
    CharacterGearExcel.AddTier(builder, Tier);
    CharacterGearExcel.AddCharacterId(builder, CharacterId);
    CharacterGearExcel.AddId(builder, Id);
    CharacterGearExcel.AddTags(builder, TagsOffset);
    CharacterGearExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    CharacterGearExcel.AddIcon(builder, IconOffset);
    CharacterGearExcel.AddMaxStatValue(builder, MaxStatValueOffset);
    CharacterGearExcel.AddMinStatValue(builder, MinStatValueOffset);
    CharacterGearExcel.AddStatType(builder, StatTypeOffset);
    CharacterGearExcel.AddLearnSkillSlot(builder, LearnSkillSlotOffset);
    CharacterGearExcel.AddStatLevelUpType(builder, StatLevelUpType);
    return CharacterGearExcel.EndCharacterGearExcel(builder);
  }

  public static void StartCharacterGearExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(1, characterId, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, SCHALE.Common.FlatData.StatLevelUpType statLevelUpType) { builder.AddInt(2, (int)statLevelUpType, 0); }
  public static void AddTier(FlatBufferBuilder builder, long tier) { builder.AddLong(3, tier, 0); }
  public static void AddNextTierEquipment(FlatBufferBuilder builder, long nextTierEquipment) { builder.AddLong(4, nextTierEquipment, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, long recipeId) { builder.AddLong(5, recipeId, 0); }
  public static void AddOpenFavorLevel(FlatBufferBuilder builder, long openFavorLevel) { builder.AddLong(6, openFavorLevel, 0); }
  public static void AddMaxLevel(FlatBufferBuilder builder, long maxLevel) { builder.AddLong(7, maxLevel, 0); }
  public static void AddLearnSkillSlot(FlatBufferBuilder builder, StringOffset learnSkillSlotOffset) { builder.AddOffset(8, learnSkillSlotOffset.Value, 0); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset statTypeOffset) { builder.AddOffset(9, statTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinStatValue(FlatBufferBuilder builder, VectorOffset minStatValueOffset) { builder.AddOffset(10, minStatValueOffset.Value, 0); }
  public static VectorOffset CreateMinStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMinStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxStatValue(FlatBufferBuilder builder, VectorOffset maxStatValueOffset) { builder.AddOffset(11, maxStatValueOffset.Value, 0); }
  public static VectorOffset CreateMaxStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(12, iconOffset.Value, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(13, localizeEtcId, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset) { builder.AddOffset(14, tagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.CharacterGearExcel> EndCharacterGearExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterGearExcel>(o);
  }
  public CharacterGearExcelT UnPack() {
    var _o = new CharacterGearExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterGearExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterGear");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.StatLevelUpType = TableEncryptionService.Convert(this.StatLevelUpType, key);
    _o.Tier = TableEncryptionService.Convert(this.Tier, key);
    _o.NextTierEquipment = TableEncryptionService.Convert(this.NextTierEquipment, key);
    _o.RecipeId = TableEncryptionService.Convert(this.RecipeId, key);
    _o.OpenFavorLevel = TableEncryptionService.Convert(this.OpenFavorLevel, key);
    _o.MaxLevel = TableEncryptionService.Convert(this.MaxLevel, key);
    _o.LearnSkillSlot = TableEncryptionService.Convert(this.LearnSkillSlot, key);
    _o.StatType = new List<SCHALE.Common.FlatData.EquipmentOptionType>();
    for (var _j = 0; _j < this.StatTypeLength; ++_j) {_o.StatType.Add(TableEncryptionService.Convert(this.StatType(_j), key));}
    _o.MinStatValue = new List<long>();
    for (var _j = 0; _j < this.MinStatValueLength; ++_j) {_o.MinStatValue.Add(TableEncryptionService.Convert(this.MinStatValue(_j), key));}
    _o.MaxStatValue = new List<long>();
    for (var _j = 0; _j < this.MaxStatValueLength; ++_j) {_o.MaxStatValue.Add(TableEncryptionService.Convert(this.MaxStatValue(_j), key));}
    _o.Icon = TableEncryptionService.Convert(this.Icon, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.Tags = new List<SCHALE.Common.FlatData.Tag>();
    for (var _j = 0; _j < this.TagsLength; ++_j) {_o.Tags.Add(TableEncryptionService.Convert(this.Tags(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.CharacterGearExcel> Pack(FlatBufferBuilder builder, CharacterGearExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.CharacterGearExcel>);
    var _LearnSkillSlot = _o.LearnSkillSlot == null ? default(StringOffset) : builder.CreateString(_o.LearnSkillSlot);
    var _StatType = default(VectorOffset);
    if (_o.StatType != null) {
      var __StatType = _o.StatType.ToArray();
      _StatType = CreateStatTypeVector(builder, __StatType);
    }
    var _MinStatValue = default(VectorOffset);
    if (_o.MinStatValue != null) {
      var __MinStatValue = _o.MinStatValue.ToArray();
      _MinStatValue = CreateMinStatValueVector(builder, __MinStatValue);
    }
    var _MaxStatValue = default(VectorOffset);
    if (_o.MaxStatValue != null) {
      var __MaxStatValue = _o.MaxStatValue.ToArray();
      _MaxStatValue = CreateMaxStatValueVector(builder, __MaxStatValue);
    }
    var _Icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _Tags = default(VectorOffset);
    if (_o.Tags != null) {
      var __Tags = _o.Tags.ToArray();
      _Tags = CreateTagsVector(builder, __Tags);
    }
    return CreateCharacterGearExcel(
      builder,
      _o.Id,
      _o.CharacterId,
      _o.StatLevelUpType,
      _o.Tier,
      _o.NextTierEquipment,
      _o.RecipeId,
      _o.OpenFavorLevel,
      _o.MaxLevel,
      _LearnSkillSlot,
      _StatType,
      _MinStatValue,
      _MaxStatValue,
      _Icon,
      _o.LocalizeEtcId,
      _Tags);
  }
}

public class CharacterGearExcelT
{
  public long Id { get; set; }
  public long CharacterId { get; set; }
  public SCHALE.Common.FlatData.StatLevelUpType StatLevelUpType { get; set; }
  public long Tier { get; set; }
  public long NextTierEquipment { get; set; }
  public long RecipeId { get; set; }
  public long OpenFavorLevel { get; set; }
  public long MaxLevel { get; set; }
  public string LearnSkillSlot { get; set; }
  public List<SCHALE.Common.FlatData.EquipmentOptionType> StatType { get; set; }
  public List<long> MinStatValue { get; set; }
  public List<long> MaxStatValue { get; set; }
  public string Icon { get; set; }
  public uint LocalizeEtcId { get; set; }
  public List<SCHALE.Common.FlatData.Tag> Tags { get; set; }

  public CharacterGearExcelT() {
    this.Id = 0;
    this.CharacterId = 0;
    this.StatLevelUpType = SCHALE.Common.FlatData.StatLevelUpType.Standard;
    this.Tier = 0;
    this.NextTierEquipment = 0;
    this.RecipeId = 0;
    this.OpenFavorLevel = 0;
    this.MaxLevel = 0;
    this.LearnSkillSlot = null;
    this.StatType = null;
    this.MinStatValue = null;
    this.MaxStatValue = null;
    this.Icon = null;
    this.LocalizeEtcId = 0;
    this.Tags = null;
  }
}


static public class CharacterGearExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*StatLevelUpType*/, 4 /*SCHALE.Common.FlatData.StatLevelUpType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Tier*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*NextTierEquipment*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*RecipeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*OpenFavorLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*MaxLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 20 /*LearnSkillSlot*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*StatType*/, 4 /*SCHALE.Common.FlatData.EquipmentOptionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*MinStatValue*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*MaxStatValue*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 28 /*Icon*/, false)
      && verifier.VerifyField(tablePos, 30 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*Tags*/, 4 /*SCHALE.Common.FlatData.Tag*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
