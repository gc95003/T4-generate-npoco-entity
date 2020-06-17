using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_SubjectQuote.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(SubjectQuoteMetadata))]
	[PrimaryKey("QuoteID")]
	[TableName("[dbo].[T_SubjectQuote]")]
    public class T_SubjectQuote 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class SubjectQuoteMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("QuoteID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SubjectID")]
			public int SubjectID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AdminID")]
			public int AdminID { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AdminRealName")]
			public string AdminRealName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("QuoteName")]
			public string QuoteName { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("QuoteUrl")]
			public string QuoteUrl { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
