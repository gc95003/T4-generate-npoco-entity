using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Regional.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(RegionalMetadata))]
	[PrimaryKey("RegionalID")]
	[TableName("[dbo].[T_Regional]")]
    public class T_Regional 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class RegionalMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RegionalID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RegionalName")]
			public string RegionalName { get; set; }

    }
  }      
}
