using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorWheel.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_OperatorWheelMetadata))]
	[PrimaryKey("WheelId")]
	[TableName("[dbo].[T_OperatorWheel]")]
    public class T_OperatorWheel 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_OperatorWheelMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("WheelId")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经销商id")]
			[Column("OperatorId")]
			public int OperatorId { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动标题")]
			[Column("ActivityTitle")]
			public string ActivityTitle { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动说明")]
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

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "审核状态 0待审核 1 已审核 ")]
			[Column("AudStatus")]
			public int AudStatus { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			
			
			[Display(Name = "访问量")]
			[Column("Hits")]
			public int? Hits { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否开启 0 已开启 1 未开启")]
			[Column("IsEnable")]
			public bool IsEnable { get; set; }

			
			
			[Display(Name = "抽奖限制")]
			[Column("AwardLimit")]
			public int? AwardLimit { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "主办方")]
			[Column("Sponsor")]
			public string Sponsor { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "联系方式")]
			[Column("LinkNumber")]
			public string LinkNumber { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "微信号")]
			[Column("WeChat")]
			public string WeChat { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "活动二维码")]
			[Column("Qrcode")]
			public string Qrcode { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "兑奖地址")]
			[Column("WheelAddress")]
			public string WheelAddress { get; set; }

    }
  }      
}
