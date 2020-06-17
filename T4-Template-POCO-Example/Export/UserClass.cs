using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a UserClass.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(UserClassMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[UserClass]")]
    public class UserClass 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class UserClassMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("GSID")]
			public int? GSID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ClassName")]
			public string ClassName { get; set; }

    }
  }      
}
