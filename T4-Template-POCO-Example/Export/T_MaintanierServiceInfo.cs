using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MaintanierServiceInfo.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MaintanierServiceInfoMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_MaintanierServiceInfo]")]
    public class T_MaintanierServiceInfo 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MaintanierServiceInfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "名称")]
			[Column("Name")]
			public string Name { get; set; }

			[StringLength(355, ErrorMessage = "{0}不能超过355个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Path")]
			public string Path { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public byte IsHot { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("HotRank")]
			public int HotRank { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
