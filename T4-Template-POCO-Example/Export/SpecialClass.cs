using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a SpecialClass.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(SpecialClassMetadata))]
	[PrimaryKey("SpecialClassID")]
	[TableName("[dbo].[SpecialClass]")]
    public class SpecialClass 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class SpecialClassMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SpecialClassID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("SpecialClassName")]
			public string SpecialClassName { get; set; }

    }
  }      
}
