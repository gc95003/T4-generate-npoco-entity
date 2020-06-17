using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_TopicDynamic.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_TopicDynamicMetadata))]
	[PrimaryKey("DynamicID")]
	[TableName("[dbo].[T_TopicDynamic]")]
    public class T_TopicDynamic 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_TopicDynamicMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "动态ID")]
			[Column("DynamicID")]
			public int Id { get; set; }

			
			
			[Display(Name = "话题ID")]
			[Column("TopicID")]
			public int? TopicID { get; set; }

			
			
			[Display(Name = "车友圈ID")]
			[Column("CircleID")]
			public int? CircleID { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "动态标题")]
			[Column("Content")]
			public string Content { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "活动内容")]
			[Column("ContentDetails")]
			public string ContentDetails { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核通过2审核拒绝")]
			[Column("Audit")]
			public int Audit { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public bool IsHot { get; set; }

			
			
			[Display(Name = "点赞量")]
			[Column("PointsInt")]
			public int? PointsInt { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题创建人")]
			[Column("CreateUserID")]
			public int CreateUserID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			
			
			[Display(Name = "审批人id")]
			[Column("OperatorUser")]
			public int? OperatorUser { get; set; }

			
			
			[Display(Name = "审批时间")]
			[Column("OperatorTime")]
			public DateTime? OperatorTime { get; set; }

			
			
			[Display(Name = "排序")]
			[Column("HotRank")]
			public int? HotRank { get; set; }

			
			
			[Display(Name = "类型id")]
			[Column("TypeId")]
			public int? TypeId { get; set; }

			
			
			[Display(Name = "城市id")]
			[Column("CityID")]
			public int? CityID { get; set; }

    }
  }      
}
