using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Salesmanshops.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(SalesmanshopsMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[Salesmanshops]")]
    public class Salesmanshops 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class SalesmanshopsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DealerstoreId")]
			public int DealerstoreId { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Shopname")]
			public string Shopname { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("ShopbannerUrl")]
			public string ShopbannerUrl { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Shopbanner")]
			public string Shopbanner { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Mainpushpictures")]
			public string Mainpushpictures { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Maintrolleyheading")]
			public string Maintrolleyheading { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Maximumdescending")]
			public string Maximumdescending { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FansInt")]
			public int FansInt { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Telephone")]
			public string Telephone { get; set; }

			
			
			[Display(Name = "")]
			[Column("DealerType")]
			public int? DealerType { get; set; }

			
			
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			
			
			[Display(Name = "是否删除")]
			[Column("IsDel")]
			public bool? IsDel { get; set; }

    }
  }      
}
