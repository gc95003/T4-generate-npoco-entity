using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MaintainerSalse.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MaintainerSalseMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_MaintainerSalse]")]
    public class T_MaintainerSalse 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MaintainerSalseMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "商家销售id")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动标题")]
			[Column("Title")]
			public string Title { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "内容")]
			[Column("Content")]
			public string Content { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "维修店铺id")]
			[Column("MaintainerId")]
			public int MaintainerId { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核拒绝2审核通过")]
			[Column("Audit")]
			public int Audit { get; set; }

			
			
			[Display(Name = "点赞数")]
			[Column("PointsInt")]
			public int? PointsInt { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public byte IsHot { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("HotRank")]
			public int HotRank { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
