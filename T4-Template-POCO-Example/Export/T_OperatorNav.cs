using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorNav.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(OperatorNavMetadata))]
	[PrimaryKey("PhotoID")]
	[TableName("[dbo].[T_OperatorNav]")]
    public class T_OperatorNav 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class OperatorNavMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("OperatorID")]
			public int? OperatorID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoTitle")]
			public string PhotoTitle { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoPath")]
			public string PhotoPath { get; set; }

			
			
			[Display(Name = "")]
			[Column("PhotoSize")]
			public int? PhotoSize { get; set; }

			
			
			[Display(Name = "")]
			[Column("RankType")]
			public byte? RankType { get; set; }

			
			
			[Display(Name = "")]
			[Column("Rank")]
			public bool? Rank { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public bool? IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("EndTime")]
			public DateTime? EndTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

    }
  }      
}
