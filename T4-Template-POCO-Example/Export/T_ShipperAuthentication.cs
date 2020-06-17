using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_ShipperAuthentication.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_ShipperAuthenticationMetadata))]
	[PrimaryKey("ShipperId")]
	[TableName("[dbo].[T_ShipperAuthentication]")]
    public class T_ShipperAuthentication 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_ShipperAuthenticationMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货主司机ID")]
			[Column("ShipperId")]
			public int Id { get; set; }

			[StringLength(150, ErrorMessage = "{0}不能超过150个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "姓名")]
			[Column("ShipperName")]
			public string ShipperName { get; set; }

			[StringLength(18, ErrorMessage = "{0}不能超过18个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "身份证号码")]
			[Column("CardId")]
			public string CardId { get; set; }

			[StringLength(335, ErrorMessage = "{0}不能超过335个字符！")]
			
			[Display(Name = "公司名称")]
			[Column("CompanyName")]
			public string CompanyName { get; set; }

			[StringLength(335, ErrorMessage = "{0}不能超过335个字符！")]
			
			[Display(Name = "公司logo")]
			[Column("CompanyLogo")]
			public string CompanyLogo { get; set; }

			[StringLength(335, ErrorMessage = "{0}不能超过335个字符！")]
			
			[Display(Name = "营业执照")]
			[Column("CompanyCert")]
			public string CompanyCert { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "公司地址")]
			[Column("CompanyAddr")]
			public string CompanyAddr { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "电话")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "驾驶证")]
			[Column("DriverLicense")]
			public string DriverLicense { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "点击量")]
			[Column("Hits")]
			public int Hits { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否热门")]
			[Column("IsHot")]
			public byte IsHot { get; set; }

			
			
			[Display(Name = "热门等级")]
			[Column("HotRank")]
			public int? HotRank { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0货主1司机")]
			[Column("ShipperType")]
			public int ShipperType { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0未审核1审核通过")]
			[Column("Audit")]
			public bool Audit { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经销商id")]
			[Column("UserId")]
			public int UserId { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

    }
  }      
}
