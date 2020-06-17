using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WxNewIsShow.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(WxNewIsShowMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_WxNewIsShow]")]
    public class T_WxNewIsShow 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class WxNewIsShowMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Value")]
			public int Value { get; set; }

    }
  }      
}
