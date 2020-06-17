using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_ProductCpcs.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ProductCpcsMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_ProductCpcs]")]
    public class T_ProductCpcs 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ProductCpcsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("Cpbh")]
			public string Cpbh { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("Name")]
			public string Name { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("NeiRong")]
			public string NeiRong { get; set; }

    }
  }      
}
