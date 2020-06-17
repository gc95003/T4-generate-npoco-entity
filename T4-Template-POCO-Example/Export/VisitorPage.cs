using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a VisitorPage.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VisitorPageMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[VisitorPage]")]
    public class VisitorPage 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VisitorPageMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyID")]
			public int? CompanyID { get; set; }

			[StringLength(500, ErrorMessage = "{0}不能超过500个字符！")]
			
			[Display(Name = "")]
			[Column("PageUrl")]
			public string PageUrl { get; set; }

			[StringLength(15, ErrorMessage = "{0}不能超过15个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			
			
			[Display(Name = "")]
			[Column("DTime")]
			public DateTime? DTime { get; set; }

    }
  }      
}
