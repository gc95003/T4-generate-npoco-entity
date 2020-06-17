using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_DealerDoorphoto.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_DealerDoorphotoMetadata))]
	[PrimaryKey("PhotoID")]
	[TableName("[dbo].[T_DealerDoorphoto]")]
    public class T_DealerDoorphoto 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_DealerDoorphotoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经销商id")]
			[Column("DealerID")]
			public int DealerID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0物流车1乘用车5维修商 6物流车经销商活动")]
			[Column("AccountType")]
			public int AccountType { get; set; }

			[StringLength(150, ErrorMessage = "{0}不能超过150个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoUrl")]
			public string PhotoUrl { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除？0否1是")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

    }
  }      
}
