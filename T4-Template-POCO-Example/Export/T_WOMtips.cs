using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WOMtips.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_WOMtipsMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_WOMtips]")]
    public class T_WOMtips 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_WOMtipsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "标识id，自增量")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "口碑标签名称")]
			[Column("Name")]
			public string Name { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0: 未删除 1：已删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "排序")]
			[Column("Rank")]
			public int Rank { get; set; }

    }
  }      
}
