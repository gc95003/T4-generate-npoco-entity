using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Honor.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(HonorMetadata))]
	[PrimaryKey("Honor_ID")]
	[TableName("[dbo].[Honor]")]
    public class Honor 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class HonorMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Honor_ID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Honor_Title")]
			public string Honor_Title { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Honor_Pic")]
			public string Honor_Pic { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsRecommend")]
			public bool? IsRecommend { get; set; }

			
			
			[Display(Name = "")]
			[Column("GSID")]
			public int? GSID { get; set; }

			
			
			[Display(Name = "")]
			[Column("Flag")]
			public int? Flag { get; set; }

    }
  }      
}
