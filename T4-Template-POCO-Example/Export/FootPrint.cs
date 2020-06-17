using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a FootPrint.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(FootPrintMetadata))]
	[PrimaryKey("id")]
	[TableName("[dbo].[FootPrint]")]
    public class FootPrint 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class FootPrintMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "自增长主键")]
			[Column("id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserId")]
			public int UserId { get; set; }

			
			
			[Display(Name = "经销商id")]
			[Column("StoreId")]
			public int? StoreId { get; set; }

			
			
			[Display(Name = "经销商类型0：物流车1：乘用车")]
			[Column("AccountType")]
			public int? AccountType { get; set; }

			
			
			[Display(Name = "访问车型id")]
			[Column("CarId")]
			public int? CarId { get; set; }

			
			
			[Display(Name = "车类型1：物流车2：乘用车")]
			[Column("CarType")]
			public int? CarType { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "访问次数")]
			[Column("Count")]
			public int Count { get; set; }

    }
  }      
}
