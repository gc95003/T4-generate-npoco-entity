using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorActivities.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(OperatorActivitiesMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_OperatorActivities]")]
    public class T_OperatorActivities 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class OperatorActivitiesMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动id")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经销商id")]
			[Column("OperatorId")]
			public int OperatorId { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动标题")]
			[Column("ActivityTitle")]
			public string ActivityTitle { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动内容")]
			[Column("ActivityContent")]
			public string ActivityContent { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "开始时间")]
			[Column("StartTime")]
			public DateTime StartTime { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "结束时间")]
			[Column("EndTime")]
			public DateTime EndTime { get; set; }

			
			
			[Display(Name = "车型id")]
			[Column("CarId")]
			public int? CarId { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "活动标签")]
			[Column("Tips")]
			public string Tips { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0 未审核 1 审核通过 2审核未通过")]
			[Column("Audit")]
			public int Audit { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除 0：未删除 1：删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

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

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0物流车经销商1乘用车经销商")]
			[Column("DealerType")]
			public int DealerType { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动分类")]
			[Column("CategroyId")]
			public int CategroyId { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "电话")]
			[Column("Mobile")]
			public string Mobile { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "维修商Id")]
			[Column("MaintenanceId")]
			public int MaintenanceId { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("IndustryType")]
			public string IndustryType { get; set; }

    }
  }      
}
