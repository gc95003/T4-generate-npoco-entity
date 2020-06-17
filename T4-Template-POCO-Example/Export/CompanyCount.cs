using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a CompanyCount.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CompanyCountMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[CompanyCount]")]
    public class CompanyCount 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CompanyCountMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyID")]
			public int? CompanyID { get; set; }

			
			
			[Display(Name = "")]
			[Column("Ctype")]
			public int? Ctype { get; set; }

			
			
			[Display(Name = "")]
			[Column("SysTime")]
			public DateTime? SysTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("Counts")]
			public int? Counts { get; set; }

    }
  }      
}
