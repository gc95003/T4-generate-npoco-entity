using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Download.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(DownloadMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[Download]")]
    public class Download 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class DownloadMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("nClass")]
			public int? NClass { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("nTitle")]
			public string NTitle { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("nAuthor")]
			public string NAuthor { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("nOriginal")]
			public string NOriginal { get; set; }

			
			
			[Display(Name = "")]
			[Column("nTime")]
			public DateTime? NTime { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("nHtmlText")]
			public string NHtmlText { get; set; }

			
			
			[Display(Name = "")]
			[Column("nFileSize")]
			public int? NFileSize { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("nAudit")]
			public bool NAudit { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("nLiulan")]
			public int NLiulan { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("nExp")]
			public string NExp { get; set; }

			
			
			[Display(Name = "")]
			[Column("nHits")]
			public int? NHits { get; set; }

			
			
			[Display(Name = "")]
			[Column("nFocus")]
			public int? NFocus { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PicUrl")]
			public string PicUrl { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Keyword")]
			public string Keyword { get; set; }

			
			
			[Display(Name = "会议id")]
			[Column("MeetingID")]
			public int? MeetingID { get; set; }

    }
  }      
}
