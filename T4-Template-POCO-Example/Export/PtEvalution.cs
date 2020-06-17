using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a PtEvalution.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(PtEvalutionMetadata))]
	[PrimaryKey("EvaID")]
	[TableName("[dbo].[PtEvalution]")]
    public class PtEvalution 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class PtEvalutionMetadata{
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

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DCQiYe")]
			public string DCQiYe { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Consume")]
			public string Consume { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Mileage")]
			public string Mileage { get; set; }

			[StringLength(500, ErrorMessage = "{0}不能超过500个字符！")]
			
			[Display(Name = "")]
			[Column("PingJia")]
			public string PingJia { get; set; }

			
			
			[Display(Name = "")]
			[Column("Rank")]
			public byte? Rank { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public byte? IsEnabled { get; set; }

    }
  }      
}
