using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Info.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(InfoMetadata))]
	[PrimaryKey("Info_ID")]
	[TableName("[dbo].[T_Info]")]
    public class T_Info 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class InfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Info_ID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("ShowName")]
			public string ShowName { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Quantity")]
			public string Quantity { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("CPGG")]
			public string CPGG { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Jgsm")]
			public string Jgsm { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("Type")]
			public string Type { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Period")]
			public string Period { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Content")]
			public string Content { get; set; }

			
			
			[Display(Name = "")]
			[Column("CategoryID")]
			public int? CategoryID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("ZW")]
			public string ZW { get; set; }

			[StringLength(40, ErrorMessage = "{0}不能超过40个字符！")]
			
			[Display(Name = "")]
			[Column("LinkMan")]
			public string LinkMan { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Company")]
			public string Company { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Mail")]
			public string Mail { get; set; }

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
			[Column("Web")]
			public string Web { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Prov")]
			public string Prov { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("City")]
			public string City { get; set; }

			
			
			[Display(Name = "")]
			[Column("DateAndTime")]
			public DateTime? DateAndTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("Gsid")]
			public int? Gsid { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			
			
			[Display(Name = "")]
			[Column("Flag")]
			public int? Flag { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

    }
  }      
}
