using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Wx_VoteResult.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(Wx_VoteResultMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[Wx_VoteResult]")]
    public class Wx_VoteResult 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class Wx_VoteResultMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OpenID")]
			public string OpenID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OptionID")]
			public int OptionID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ClassID")]
			public int ClassID { get; set; }

			[StringLength(16, ErrorMessage = "{0}不能超过16个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("WXnickName")]
			public string WXnickName { get; set; }

			[StringLength(2, ErrorMessage = "{0}不能超过2个字符！")]
			
			[Display(Name = "")]
			[Column("WXGender")]
			public string WXGender { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("WXAvatarUrl")]
			public string WXAvatarUrl { get; set; }

    }
  }      
}
