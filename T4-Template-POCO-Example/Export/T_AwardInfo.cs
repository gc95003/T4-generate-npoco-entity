using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_AwardInfo.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(AwardInfoMetadata))]
	[PrimaryKey("AwardUserID")]
	[TableName("[dbo].[T_AwardInfo]")]
    public class T_AwardInfo 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class AwardInfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AwardUserID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "获奖者呢称")]
			[Column("AwardWinner")]
			public string AwardWinner { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "奖品")]
			[Column("AwardID")]
			public int AwardID { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "中奖时间")]
			[Column("AwardDate")]
			public DateTime AwardDate { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "微信id")]
			[Column("WxUser")]
			public int WxUser { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "兑奖码(唯一)")]
			[Column("AwardCode")]
			public string AwardCode { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "联系电话")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未兑换  1已兑换 2 已失效 ")]
			[Column("Status")]
			public int Status { get; set; }

			
			
			[Display(Name = "领奖时间")]
			[Column("ReceiveTime")]
			public DateTime? ReceiveTime { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "兑奖二维码")]
			[Column("AwardQRCode")]
			public string AwardQRCode { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0谢谢惠顾1奖品")]
			[Column("IsHit")]
			public bool IsHit { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "真实姓名")]
			[Column("RealName")]
			public string RealName { get; set; }

    }
  }      
}
