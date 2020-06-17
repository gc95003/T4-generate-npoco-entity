using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_AwardWheel.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_AwardWheelMetadata))]
	[PrimaryKey("AwardID")]
	[TableName("[dbo].[T_AwardWheel]")]
    public class T_AwardWheel 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_AwardWheelMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AwardID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "活动id")]
			[Column("WheelId")]
			public int WheelId { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "奖品等级")]
			[Column("AwardLevel")]
			public string AwardLevel { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "奖品名称")]
			[Column("AwardTitle")]
			public string AwardTitle { get; set; }

			
			
			[Display(Name = "奖品总量")]
			[Column("Amount")]
			public int? Amount { get; set; }

			
			
			[Display(Name = " 奖品剩余")]
			[Column("AmountBalance")]
			public int? AmountBalance { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "图片路径")]
			[Column("AwardPath")]
			public string AwardPath { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "概率")]
			[Column("AwardRate")]
			public decimal AwardRate { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "兑奖期限")]
			[Column("AwardBeginDate")]
			public DateTime AwardBeginDate { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "兑奖期限2")]
			[Column("AwardEndDate")]
			public DateTime AwardEndDate { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0谢谢惠顾1奖品")]
			[Column("IsHit")]
			public bool IsHit { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

    }
  }      
}
