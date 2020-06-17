using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CircleList.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CircleListMetadata))]
	[PrimaryKey("CircleID")]
	[TableName("[dbo].[T_CircleList]")]
    public class T_CircleList 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CircleListMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车友圈ID")]
			[Column("CircleID")]
			public int Id { get; set; }

			[StringLength(350, ErrorMessage = "{0}不能超过350个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "圈子名称")]
			[Column("CircleName")]
			public string CircleName { get; set; }

			[StringLength(350, ErrorMessage = "{0}不能超过350个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "圈子logo")]
			[Column("CircleLogo")]
			public string CircleLogo { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "圈子简介")]
			[Column("CircleProfiles")]
			public string CircleProfiles { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "申请人ID")]
			[Column("ApplyUserID")]
			public int ApplyUserID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "申请人姓名")]
			[Column("UserName")]
			public string UserName { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "电话")]
			[Column("UserTel")]
			public string UserTel { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "地址")]
			[Column("Addres")]
			public string Addres { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否热门")]
			[Column("IsHot")]
			public bool IsHot { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否推荐")]
			[Column("IsRecommend")]
			public bool IsRecommend { get; set; }

			
			
			[Display(Name = "热门等级")]
			[Column("HotRank")]
			public int? HotRank { get; set; }

			
			
			[Display(Name = "车系id")]
			[Column("SeriesID")]
			public int? SeriesID { get; set; }

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

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核通过 2审核拒绝")]
			[Column("Audit")]
			public int Audit { get; set; }

			
			
			[Display(Name = "操作人id")]
			[Column("OperatorUser")]
			public int? OperatorUser { get; set; }

			
			
			[Display(Name = "操作时间")]
			[Column("OperatorTime")]
			public DateTime? OperatorTime { get; set; }

    }
  }      
}
