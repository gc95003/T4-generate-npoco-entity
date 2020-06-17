using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_YearInfo.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(YearInfoMetadata))]
	[PrimaryKey("YearID")]
	[TableName("[dbo].[T_YearInfo]")]
    public class T_YearInfo 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class YearInfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("YearID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("YearName")]
			public string YearName { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public byte? IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

    }
  }      
}
