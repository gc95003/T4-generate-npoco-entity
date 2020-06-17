using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CircleCommunity.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CircleCommunityMetadata))]
	[PrimaryKey("CommunityId")]
	[TableName("[dbo].[T_CircleCommunity]")]
    public class T_CircleCommunity 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CircleCommunityMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "司机社群id")]
			[Column("CommunityId")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "群名称")]
			[Column("CommunityName")]
			public string CommunityName { get; set; }

			[StringLength(225, ErrorMessage = "{0}不能超过225个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "群logo")]
			[Column("CommunityLogo")]
			public string CommunityLogo { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "简介")]
			[Column("Profiles")]
			public string Profiles { get; set; }

			
			
			[Display(Name = "城市id")]
			[Column("CityID")]
			public int? CityID { get; set; }

			
			
			[Display(Name = "阅读量")]
			[Column("Hits")]
			public int? Hits { get; set; }

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

			
			
			[Display(Name = "排序")]
			[Column("HotRank")]
			public int? HotRank { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
