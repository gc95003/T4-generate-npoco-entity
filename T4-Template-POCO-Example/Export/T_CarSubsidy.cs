using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarSubsidy.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CarSubsidyMetadata))]
	[PrimaryKey("SubsidyID")]
	[TableName("[dbo].[T_CarSubsidy]")]
    public class T_CarSubsidy 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CarSubsidyMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SubsidyID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ParentID")]
			public int ParentID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SubsidyName")]
			public string SubsidyName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("UsageID")]
			public int UsageID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AreaID")]
			public int AreaID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Year")]
			public int Year { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Amount")]
			public int Amount { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MinMileage")]
			public decimal MinMileage { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MaxMileage")]
			public decimal MaxMileage { get; set; }

    }
  }      
}
