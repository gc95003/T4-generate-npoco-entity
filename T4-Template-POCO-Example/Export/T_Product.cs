using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Product.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_ProductMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_Product]")]
    public class T_Product 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_ProductMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cpbh")]
			public string Cpbh { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cpmc")]
			public string Cpmc { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Sccj")]
			public string Sccj { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cpsb")]
			public string Cpsb { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cpcd")]
			public string Cpcd { get; set; }

			
			
			[Display(Name = "")]
			[Column("Cpjg")]
			public int? Cpjg { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cpgg")]
			public string Cpgg { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Picture")]
			public string Picture { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Jysm")]
			public string Jysm { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Xxsm")]
			public string Xxsm { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Web")]
			public string Web { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Email")]
			public string Email { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Sf")]
			public string Sf { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("City")]
			public string City { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Mobile")]
			public string Mobile { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Phone")]
			public string Phone { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Fax")]
			public string Fax { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("LXR")]
			public string LXR { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Zw")]
			public string Zw { get; set; }

			
			
			[Display(Name = "")]
			[Column("GsID")]
			public int? GsID { get; set; }

			
			
			[Display(Name = "")]
			[Column("Vip")]
			public int? Vip { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Zsbz")]
			public string Zsbz { get; set; }

			
			
			[Display(Name = "")]
			[Column("Flag")]
			public int? Flag { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			
			
			[Display(Name = "")]
			[Column("IDate")]
			public DateTime? IDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("OrderID")]
			public int? OrderID { get; set; }

			
			
			[Display(Name = "")]
			[Column("MyClassID")]
			public int? MyClassID { get; set; }

			
			
			[Display(Name = "")]
			[Column("CategoryID")]
			public int? CategoryID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Tags")]
			public string Tags { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsRecommend")]
			public int? IsRecommend { get; set; }

    }
  }      
}
