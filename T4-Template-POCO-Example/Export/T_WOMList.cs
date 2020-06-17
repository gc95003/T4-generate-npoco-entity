using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WOMList.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_WOMListMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_WOMList]")]
    public class T_WOMList 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_WOMListMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车系id")]
			[Column("SeriesId")]
			public int SeriesId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车型id")]
			[Column("CarId")]
			public int CarId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserId")]
			public int UserId { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "口碑内容")]
			[Column("Detail")]
			public string Detail { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除 0：未删除 1：删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否置顶 0 否 1是")]
			[Column("IsStick")]
			public bool IsStick { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否精品 0 否 1 是")]
			[Column("IsBoutique")]
			public bool IsBoutique { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0 未审核 1 审核通过 2审核未通过")]
			[Column("Audit")]
			public int Audit { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "标签")]
			[Column("Tips")]
			public string Tips { get; set; }

			
			
			[Display(Name = "点赞数量")]
			[Column("support")]
			public int? Support { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "追加父级id")]
			[Column("ParentId")]
			public int ParentId { get; set; }

			
			
			[Display(Name = "购买价格")]
			[Column("BuyPrice")]
			public decimal? BuyPrice { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "购买地点")]
			[Column("BuyCity")]
			public string BuyCity { get; set; }

    }
  }      
}
