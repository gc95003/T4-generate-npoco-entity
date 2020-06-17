using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MaintainerCollection.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MaintainerCollectionMetadata))]
	[PrimaryKey("CollectionId")]
	[TableName("[dbo].[T_MaintainerCollection]")]
    public class T_MaintainerCollection 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MaintainerCollectionMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CollectionId")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "维修店铺id")]
			[Column("MaintainerId")]
			public int MaintainerId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0物流车1乘用车5维修商")]
			[Column("Type")]
			public int Type { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("UserId")]
			public int UserId { get; set; }

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
