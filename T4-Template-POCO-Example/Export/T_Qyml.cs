using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Qyml.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_QymlMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_Qyml]")]
    public class T_Qyml 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_QymlMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("BBSUserID")]
			public int BBSUserID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Qymc")]
			public string Qymc { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("Qyjc")]
			public string Qyjc { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("FirstChar")]
			public string FirstChar { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Qylb")]
			public string Qylb { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Zh")]
			public string Zh { get; set; }

			[StringLength(500, ErrorMessage = "{0}不能超过500个字符！")]
			
			[Display(Name = "")]
			[Column("Jygs")]
			public string Jygs { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("Sf")]
			public string Sf { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("City")]
			public string City { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Mobile")]
			public string Mobile { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Phone")]
			public string Phone { get; set; }

			[StringLength(40, ErrorMessage = "{0}不能超过40个字符！")]
			
			[Display(Name = "")]
			[Column("Fax")]
			public string Fax { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Email")]
			public string Email { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Web")]
			public string Web { get; set; }

			[StringLength(40, ErrorMessage = "{0}不能超过40个字符！")]
			
			[Display(Name = "")]
			[Column("Name")]
			public string Name { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("Ch")]
			public string Ch { get; set; }

			[StringLength(40, ErrorMessage = "{0}不能超过40个字符！")]
			
			[Display(Name = "")]
			[Column("Zw")]
			public string Zw { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Tjbz")]
			public string Tjbz { get; set; }

			
			
			[Display(Name = "")]
			[Column("Flag")]
			public int? Flag { get; set; }

			
			
			[Display(Name = "")]
			[Column("Uflag")]
			public int? Uflag { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Cimg")]
			public string Cimg { get; set; }

			
			
			[Display(Name = "")]
			[Column("Click")]
			public int? Click { get; set; }

			
			
			[Display(Name = "")]
			[Column("Idate")]
			public DateTime? Idate { get; set; }

			
			
			[Display(Name = "")]
			[Column("BeginDate")]
			public DateTime? BeginDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("EndDate")]
			public DateTime? EndDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("Uplist")]
			public DateTime? Uplist { get; set; }

			
			
			[Display(Name = "")]
			[Column("OrderID")]
			public int? OrderID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Blaner")]
			public string Blaner { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("QQ")]
			public string QQ { get; set; }

			
			
			[Display(Name = "")]
			[Column("StyleID")]
			public int? StyleID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Clogo")]
			public string Clogo { get; set; }

			
			
			[Display(Name = "")]
			[Column("CategoryID")]
			public int? CategoryID { get; set; }

    }
  }      
}
