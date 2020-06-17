using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VoteContact.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_VoteContactMetadata))]
	[PrimaryKey("ContactID")]
	[TableName("[dbo].[T_VoteContact]")]
    public class T_VoteContact 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_VoteContactMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ContactID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ThemeID")]
			public int ThemeID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("GroupCode")]
			public string GroupCode { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("CompanyName")]
			public string CompanyName { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("UserName")]
			public string UserName { get; set; }

			
			
			[Display(Name = "")]
			[Column("Sex")]
			public bool? Sex { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("Fax")]
			public string Fax { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Email")]
			public string Email { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("Post")]
			public string Post { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
