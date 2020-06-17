using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MaterialUsedTags.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_MaterialUsedTagsMetadata))]
	[PrimaryKey("MaterialID")]
	[TableName("[dbo].[T_MaterialUsedTags]")]
    public class T_MaterialUsedTags 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_MaterialUsedTagsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TagID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MaterialID")]
			public int Id { get; set; }

    }
  }      
}
