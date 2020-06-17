using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CircleTopic.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CircleTopicMetadata))]
	[PrimaryKey("TopicID")]
	[TableName("[dbo].[T_CircleTopic]")]
    public class T_CircleTopic 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CircleTopicMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题id")]
			[Column("TopicID")]
			public int Id { get; set; }

			[StringLength(350, ErrorMessage = "{0}不能超过350个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题logo")]
			[Column("TopicLogo")]
			public string TopicLogo { get; set; }

			[StringLength(350, ErrorMessage = "{0}不能超过350个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题名称")]
			[Column("TopicName")]
			public string TopicName { get; set; }

			[StringLength(950, ErrorMessage = "{0}不能超过950个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题内容")]
			[Column("TopicContent")]
			public string TopicContent { get; set; }

			
			
			[Display(Name = "阅读量")]
			[Column("Hits")]
			public int? Hits { get; set; }

			
			
			[Display(Name = "点赞数")]
			[Column("PointsInt")]
			public int? PointsInt { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public bool IsHot { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题创建人")]
			[Column("CreateUserID")]
			public int CreateUserID { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核拒绝2审核通过")]
			[Column("Audit")]
			public int Audit { get; set; }

			
			
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

			
			
			[Display(Name = "地区id")]
			[Column("CityID")]
			public int? CityID { get; set; }

    }
  }      
}
