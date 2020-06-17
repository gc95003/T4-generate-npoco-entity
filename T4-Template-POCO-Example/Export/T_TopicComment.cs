using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_TopicComment.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_TopicCommentMetadata))]
	[PrimaryKey("CommentID")]
	[TableName("[dbo].[T_TopicComment]")]
    public class T_TopicComment 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_TopicCommentMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "评论ID")]
			[Column("CommentID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "评论上级Id")]
			[Column("ParentId")]
			public int ParentId { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "评论内容")]
			[Column("Details")]
			public string Details { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserId")]
			public int UserId { get; set; }

			
			
			[Display(Name = "回复用户id")]
			[Column("ToUserId")]
			public int? ToUserId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "动态id")]
			[Column("DynamicID")]
			public int DynamicID { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除 0否 1是")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			
			
			[Display(Name = "点赞量")]
			[Column("PointsInt")]
			public int? PointsInt { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核通过2审核拒绝")]
			[Column("Audit")]
			public int Audit { get; set; }

			
			
			[Display(Name = "审批人id")]
			[Column("OperatorUser")]
			public int? OperatorUser { get; set; }

			
			
			[Display(Name = "审批时间")]
			[Column("OperatorTime")]
			public DateTime? OperatorTime { get; set; }

    }
  }      
}
