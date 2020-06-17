using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_ShipperCargoInfo.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ShipperCargoInfoMetadata))]
	[PrimaryKey("CargoId")]
	[TableName("[dbo].[T_ShipperCargoInfo]")]
    public class T_ShipperCargoInfo 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ShipperCargoInfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货物信息id")]
			[Column("CargoId")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货物名称")]
			[Column("CargoName")]
			public string CargoName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货物类别id")]
			[Column("CategoryId")]
			public int CategoryId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "包装方式id")]
			[Column("PackingTypeId")]
			public int PackingTypeId { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "运输费用")]
			[Column("TransportationPrice")]
			public decimal TransportationPrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "件数")]
			[Column("Pieces")]
			public int Pieces { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "重量")]
			[Column("CargoWeight")]
			public decimal CargoWeight { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CargoLength")]
			public int CargoLength { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CargoWidth")]
			public int CargoWidth { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CargoHeight")]
			public int CargoHeight { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "支付方式1回单付，2到付")]
			[Column("PayMethod")]
			public int PayMethod { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用车类型")]
			[Column("UseType")]
			public int UseType { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车长")]
			[Column("CarLength")]
			public int CarLength { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车型")]
			[Column("CarType")]
			public int CarType { get; set; }

			
			
			[Display(Name = "发货时间")]
			[Column("ShipmentsTime")]
			public DateTime? ShipmentsTime { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "备注")]
			[Column("Remarks")]
			public string Remarks { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经销商id")]
			[Column("UserId")]
			public int UserId { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否热门")]
			[Column("IsHot")]
			public byte IsHot { get; set; }

			
			
			[Display(Name = "热门等级")]
			[Column("HotRank")]
			public int? HotRank { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "联系电话")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "联系人")]
			[Column("LinkMan")]
			public string LinkMan { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "地址")]
			[Column("LinkAddr")]
			public string LinkAddr { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "联系人头像")]
			[Column("LinkManPic")]
			public string LinkManPic { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			
			[Display(Name = "")]
			[Column("StartTime")]
			public string StartTime { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			
			[Display(Name = "")]
			[Column("EndTime")]
			public string EndTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0 实时，1 期限")]
			[Column("TimeType")]
			public int TimeType { get; set; }

			
			
			[Display(Name = "是否审核 0 待审核 1已审核2审核未通过")]
			[Column("Isaudit")]
			public int? Isaudit { get; set; }

			
			
			[Display(Name = "是否删除  0正常 1删除")]
			[Column("IsDelete")]
			public int? IsDelete { get; set; }

    }
  }      
}
