using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_TopicCollection.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(TopicCollectionMetadata))]
	[PrimaryKey("CollectionID")]
	[TableName("[dbo].[T_TopicCollection]")]
    public class T_TopicCollection 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class TopicCollectionMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "收藏ID")]
			[Column("CollectionID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "圈子ID")]
			[Column("CircleID")]
			public int CircleID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserID")]
			public int UserID { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsDel")]
			public bool? IsDel { get; set; }

    }
  }      
}
