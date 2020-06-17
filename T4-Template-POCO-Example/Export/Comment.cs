using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Comment.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CommentMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[Comment]")]
    public class Comment 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CommentMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("UserID")]
			public int? UserID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("NickName")]
			public string NickName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "5:专题;6:车企风云榜;7:新闻资讯;8:企业秀品牌;9:企业秀人物;10:会议;11:视频;12:企业新闻;13:微课堂;14:物流车挑战赛-投票;")]
			[Column("ClassID")]
			public int ClassID { get; set; }

			
			
			[Display(Name = "")]
			[Column("NewsID")]
			public int? NewsID { get; set; }

			
			
			[Display(Name = "")]
			[Column("ReplayID")]
			public int? ReplayID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TuiJian")]
			public int TuiJian { get; set; }

			[StringLength(500, ErrorMessage = "{0}不能超过500个字符！")]
			
			[Display(Name = "")]
			[Column("Content")]
			public string Content { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsAudit")]
			public bool? IsAudit { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsHot")]
			public bool? IsHot { get; set; }

			[StringLength(15, ErrorMessage = "{0}不能超过15个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDeleted")]
			public byte IsDeleted { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ExtendID")]
			public int ExtendID { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0主站1车货通小程序2会议小程序3乘用车小程序")]
			[Column("UserType")]
			public int UserType { get; set; }

    }
  }      
}
