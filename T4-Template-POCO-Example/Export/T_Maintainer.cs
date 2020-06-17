using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Maintainer.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MaintainerMetadata))]
	[PrimaryKey("MaintainerId")]
	[TableName("[dbo].[T_Maintainer]")]
    public class T_Maintainer 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MaintainerMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "维修店铺id")]
			[Column("MaintainerId")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "账号")]
			[Column("Account")]
			public string Account { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "密码")]
			[Column("Password")]
			public string Password { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "logo")]
			[Column("Logo")]
			public string Logo { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "名称")]
			[Column("Name")]
			public string Name { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "简介")]
			[Column("Profiles")]
			public string Profiles { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "设施")]
			[Column("Facilities")]
			public string Facilities { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "营业时间")]
			[Column("OpenTime")]
			public string OpenTime { get; set; }

			[StringLength(35, ErrorMessage = "{0}不能超过35个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "联系人")]
			[Column("Contacts")]
			public string Contacts { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "联系电话")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "地区id")]
			[Column("AreaId")]
			public int AreaId { get; set; }

			[StringLength(150, ErrorMessage = "{0}不能超过150个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			
			
			[Display(Name = "入驻费用")]
			[Column("EntryFee")]
			public decimal? EntryFee { get; set; }

			
			
			[Display(Name = "1物流车2乘用车")]
			[Column("DealerType")]
			public int? DealerType { get; set; }

			
			
			[Display(Name = "经销商id")]
			[Column("DealerId")]
			public int? DealerId { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核通过")]
			[Column("Audit")]
			public bool Audit { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经度")]
			[Column("Longitude")]
			public decimal Longitude { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "维度")]
			[Column("Latitude")]
			public decimal Latitude { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			[StringLength(150, ErrorMessage = "{0}不能超过150个字符！")]
			
			[Display(Name = "二维码")]
			[Column("DealerQrCode")]
			public string DealerQrCode { get; set; }

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
			[Display(Name = "")]
			[Column("IsRecommend")]
			public byte IsRecommend { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RecommendRank")]
			public int RecommendRank { get; set; }

			[StringLength(32, ErrorMessage = "{0}不能超过32个字符！")]
			
			[Display(Name = "微信公众号id或小程序id")]
			[Column("OpenID")]
			public string OpenID { get; set; }

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
