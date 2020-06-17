using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MediaAuthorVerify.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MediaAuthorVerifyMetadata))]
	[PrimaryKey("AuthorID")]
	[TableName("[dbo].[T_MediaAuthorVerify]")]
    public class T_MediaAuthorVerify 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MediaAuthorVerifyMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AuthorID")]
			public int Id { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AuthorName")]
			public string AuthorName { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FirstChar")]
			public string FirstChar { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Profession")]
			public string Profession { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Avatar")]
			public string Avatar { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AreaID")]
			public int AreaID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Gender")]
			public byte Gender { get; set; }

			[StringLength(120, ErrorMessage = "{0}不能超过120个字符！")]
			
			[Display(Name = "")]
			[Column("Signature")]
			public string Signature { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Mobile")]
			public string Mobile { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("WeiXin")]
			public string WeiXin { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("QQ")]
			public string QQ { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("SinaWeibo")]
			public string SinaWeibo { get; set; }

			[StringLength(2, ErrorMessage = "{0}不能超过2个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Flag")]
			public Int16 Flag { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
