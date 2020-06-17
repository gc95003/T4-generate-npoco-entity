using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarIndexAd.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CarIndexAdMetadata))]
	[PrimaryKey("PhotoID")]
	[TableName("[dbo].[T_CarIndexAd]")]
    public class T_CarIndexAd 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CarIndexAdMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoTitle")]
			public string PhotoTitle { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			
			
			[Display(Name = "")]
			[Column("Rank")]
			public int? Rank { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public int? IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Xhang")]
			public string Xhang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Price")]
			public string Price { get; set; }

			
			
			[Display(Name = "")]
			[Column("RankType")]
			public int? RankType { get; set; }

    }
  }      
}
