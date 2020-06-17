using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_DealerAccount.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_DealerAccountMetadata))]
	[PrimaryKey("AccountId")]
	[TableName("[dbo].[T_DealerAccount]")]
    public class T_DealerAccount 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_DealerAccountMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AccountId")]
			public int Id { get; set; }

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
			
			[Display(Name = "微信公众号id或小程序id")]
			[Column("OpenID")]
			public string OpenID { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsAudit")]
			public byte? IsAudit { get; set; }

			
			
			[Display(Name = "经销商类型0物流车1乘用车2乘商综合")]
			[Column("DealerType")]
			public int? DealerType { get; set; }

    }
  }      
}
