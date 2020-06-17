using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_DepartmentFuncList.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_DepartmentFuncListMetadata))]
	[PrimaryKey("RelationID")]
	[TableName("[dbo].[T_DepartmentFuncList]")]
    public class T_DepartmentFuncList 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_DepartmentFuncListMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelationID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DepartmentID")]
			public int DepartmentID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FuncID")]
			public int FuncID { get; set; }

    }
  }      
}
