using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_IndexAd.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(IndexAdMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_IndexAd]")]
    public class T_IndexAd 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class IndexAdMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int ID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoTitle")]
			public string PhotoTitle { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
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
			public int? Rank { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public bool? IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("Type")]
			public byte? Type { get; set; }

    }
  }      
}
