using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VehicleEvalution.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VehicleEvalutionMetadata))]
	[PrimaryKey("EvaID")]
	[TableName("[dbo].[T_VehicleEvalution]")]
    public class T_VehicleEvalution 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VehicleEvalutionMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("EvaID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleID")]
			public int VehicleID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("NewsID")]
			public int NewsID { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RealMileage")]
			public decimal RealMileage { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RealConsume")]
			public decimal RealConsume { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RealCharging")]
			public decimal RealCharging { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RealLoad")]
			public decimal RealLoad { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OfficialMileage")]
			public decimal OfficialMileage { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OfficialConsume")]
			public decimal OfficialConsume { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OfficialCharging")]
			public decimal OfficialCharging { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OfficialLoad")]
			public decimal OfficialLoad { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("ConsumeEvalution")]
			public string ConsumeEvalution { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("LoadEvalution")]
			public string LoadEvalution { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("ChargingEvalution")]
			public string ChargingEvalution { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("PerformanceEvalution")]
			public string PerformanceEvalution { get; set; }

			[StringLength(500, ErrorMessage = "{0}不能超过500个字符！")]
			
			[Display(Name = "")]
			[Column("Overview")]
			public string Overview { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Score")]
			public decimal Score { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PageID")]
			public byte PageID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public byte Rank { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsEnabled")]
			public bool IsEnabled { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
