using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_TagsRelationships.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(TagsRelationshipsMetadata))]
	[PrimaryKey("RelationID")]
	[TableName("[dbo].[T_TagsRelationships]")]
    public class T_TagsRelationships 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class TagsRelationshipsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelationID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TagID")]
			public int TagID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("InfoID")]
			public int InfoID { get; set; }

    }
  }      
}
