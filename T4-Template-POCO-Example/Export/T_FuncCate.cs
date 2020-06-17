using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_FuncCate.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(FuncCateMetadata))]
	[PrimaryKey("FuncCateID")]
	[TableName("[dbo].[T_FuncCate]")]
    public class T_FuncCate 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class FuncCateMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FuncCateID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FuncCateName")]
			public string FuncCateName { get; set; }

    }
  }      
}
