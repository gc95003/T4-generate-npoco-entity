using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VehicleAttributeSet_20180809.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VehicleAttributeSet_20180809Metadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_VehicleAttributeSet_20180809]")]
    public class T_VehicleAttributeSet_20180809 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VehicleAttributeSet_20180809Metadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AttributeSetID")]
			public int AttributeSetID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AttributeSetName")]
			public string AttributeSetName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("UsageID")]
			public int UsageID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

    }
  }      
}
