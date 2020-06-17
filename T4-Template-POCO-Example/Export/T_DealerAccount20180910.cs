using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_DealerAccount20180910.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(DealerAccount20180910Metadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_DealerAccount20180910]")]
    public class T_DealerAccount20180910 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class DealerAccount20180910Metadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AccountId")]
			public int AccountId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DealerId")]
			public int DealerId { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsLocked")]
			public bool IsLocked { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Account")]
			public string Account { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Password")]
			public string Password { get; set; }

			
			
			[Display(Name = "")]
			[Column("Longitude")]
			public decimal? Longitude { get; set; }

			
			
			[Display(Name = "")]
			[Column("Latitude")]
			public decimal? Latitude { get; set; }

			
			
			[Display(Name = "")]
			[Column("LastTime")]
			public DateTime? LastTime { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Hits")]
			public int Hits { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AccountType")]
			public int AccountType { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("SessionKey")]
			public string SessionKey { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("UserDevice")]
			public string UserDevice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Loginstate")]
			public int Loginstate { get; set; }

			[StringLength(32, ErrorMessage = "{0}不能超过32个字符！")]
			
			[Display(Name = "")]
			[Column("OpenID")]
			public string OpenID { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsAudit")]
			public byte? IsAudit { get; set; }

			
			
			[Display(Name = "")]
			[Column("DealerType")]
			public int? DealerType { get; set; }

    }
  }      
}
