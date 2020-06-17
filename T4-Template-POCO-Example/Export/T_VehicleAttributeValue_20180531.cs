using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VehicleAttributeValue_20180531.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VehicleAttributeValue_20180531Metadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_VehicleAttributeValue_20180531]")]
    public class T_VehicleAttributeValue_20180531 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VehicleAttributeValue_20180531Metadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelationID")]
			public int RelationID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleID")]
			public int VehicleID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AttributeID")]
			public int AttributeID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("SelectedID")]
			public string SelectedID { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("SelectedValue")]
			public string SelectedValue { get; set; }

    }
  }      
}
