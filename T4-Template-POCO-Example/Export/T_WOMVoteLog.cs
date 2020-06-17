using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WOMVoteLog.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(WOMVoteLogMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_WOMVoteLog]")]
    public class T_WOMVoteLog 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class WOMVoteLogMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserId")]
			public int UserId { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "被点赞内容id")]
			[Column("BbsId")]
			public int BbsId { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "点赞类型 1 口碑 2 评论 3圈子动态4圈子评论5维修商动态6维修商动态评论")]
			[Column("AddType")]
			public byte AddType { get; set; }

    }
  }      
}
