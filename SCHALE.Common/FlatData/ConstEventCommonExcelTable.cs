// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ConstEventCommonExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstEventCommonExcelTable GetRootAsConstEventCommonExcelTable(ByteBuffer _bb) { return GetRootAsConstEventCommonExcelTable(_bb, new ConstEventCommonExcelTable()); }
  public static ConstEventCommonExcelTable GetRootAsConstEventCommonExcelTable(ByteBuffer _bb, ConstEventCommonExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstEventCommonExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.ConstEventCommonExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.ConstEventCommonExcel?)(new SCHALE.Common.FlatData.ConstEventCommonExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.ConstEventCommonExcelTable> CreateConstEventCommonExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    ConstEventCommonExcelTable.AddDataList(builder, DataListOffset);
    return ConstEventCommonExcelTable.EndConstEventCommonExcelTable(builder);
  }

  public static void StartConstEventCommonExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.ConstEventCommonExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.ConstEventCommonExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.ConstEventCommonExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.ConstEventCommonExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.ConstEventCommonExcelTable> EndConstEventCommonExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConstEventCommonExcelTable>(o);
  }
  public ConstEventCommonExcelTableT UnPack() {
    var _o = new ConstEventCommonExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstEventCommonExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConstEventCommonExcel");
    _o.DataList = new List<SCHALE.Common.FlatData.ConstEventCommonExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<SCHALE.Common.FlatData.ConstEventCommonExcelTable> Pack(FlatBufferBuilder builder, ConstEventCommonExcelTableT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ConstEventCommonExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<SCHALE.Common.FlatData.ConstEventCommonExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = SCHALE.Common.FlatData.ConstEventCommonExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateConstEventCommonExcelTable(
      builder,
      _DataList);
  }
}

public class ConstEventCommonExcelTableT
{
  public List<SCHALE.Common.FlatData.ConstEventCommonExcelT> DataList { get; set; }

  public ConstEventCommonExcelTableT() {
    this.DataList = null;
  }
}


static public class ConstEventCommonExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, SCHALE.Common.FlatData.ConstEventCommonExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
