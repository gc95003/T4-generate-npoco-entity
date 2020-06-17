using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_UserDown.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_UserDownMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_UserDown]")]
    public class T_UserDown 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_UserDownMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int ID { get; set; }

			
			
			[Display(Name = "")]
			[Column("UserID")]
			public int? UserID { get; set; }

			
			
			[Display(Name = "")]
			[Column("DownID")]
			public int? DownID { get; set; }

    }
  }      
}
