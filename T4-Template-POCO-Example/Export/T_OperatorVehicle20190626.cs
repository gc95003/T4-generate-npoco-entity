using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorVehicle20190626.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(OperatorVehicle20190626Metadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_OperatorVehicle20190626]")]
    public class T_OperatorVehicle20190626 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class OperatorVehicle20190626Metadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelatedID")]
			public int RelatedID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OperatorID")]
			public int OperatorID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleID")]
			public int VehicleID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("VehiclePhoto")]
			public string VehiclePhoto { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MSRP")]
			public decimal MSRP { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ShopPrice")]
			public decimal ShopPrice { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("LeasePrice")]
			public decimal LeasePrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Mhits")]
			public int Mhits { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Hits")]
			public int Hits { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsTop")]
			public bool IsTop { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsRecommend")]
			public bool IsRecommend { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsDelete")]
			public bool? IsDelete { get; set; }

    }
  }      
}
