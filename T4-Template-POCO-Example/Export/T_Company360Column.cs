using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Company360Column.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(Company360ColumnMetadata))]
	[PrimaryKey("ColumnID")]
	[TableName("[dbo].[T_Company360Column]")]
    public class T_Company360Column 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class Company360ColumnMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ColumnID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CompanyID")]
			public int CompanyID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ColumnType")]
			public int ColumnType { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ColumnName")]
			public string ColumnName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

    }
  }      
}
