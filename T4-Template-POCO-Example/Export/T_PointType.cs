using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_PointType.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(PointTypeMetadata))]
	[PrimaryKey("PointTypeID")]
	[TableName("[dbo].[T_PointType]")]
    public class T_PointType 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class PointTypeMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PointTypeID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PointTypeName")]
			public string PointTypeName { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDeleted")]
			public bool IsDeleted { get; set; }

    }
  }      
}
