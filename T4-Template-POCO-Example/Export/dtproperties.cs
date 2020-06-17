using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a dtproperties.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(dtpropertiesMetadata))]
	[PrimaryKey("property")]
	[TableName("[dbo].[dtproperties]")]
    public class dtproperties 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class dtpropertiesMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("id")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("objectid")]
			public int? Objectid { get; set; }

			[StringLength(64, ErrorMessage = "{0}不能超过64个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("property")]
			public string Id { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("value")]
			public string Value { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("uvalue")]
			public string Uvalue { get; set; }

			
			
			[Display(Name = "")]
			[Column("lvalue")]
			public byte[]? Lvalue { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("version")]
			public int Version { get; set; }

    }
  }      
}
