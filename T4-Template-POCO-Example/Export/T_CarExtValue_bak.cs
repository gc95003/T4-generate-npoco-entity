using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarExtValue_bak.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CarExtValue_bakMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_CarExtValue_bak]")]
    public class T_CarExtValue_bak 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CarExtValue_bakMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelationID")]
			public int RelationID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CarID")]
			public int CarID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ItemID")]
			public int ItemID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("ItemValue")]
			public string ItemValue { get; set; }

    }
  }      
}
