using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_ShipperAuthenticationInfo.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ShipperAuthenticationInfoMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_ShipperAuthenticationInfo]")]
    public class T_ShipperAuthenticationInfo 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ShipperAuthenticationInfoMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "身份认证id")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货主司机ID")]
			[Column("ShipperId")]
			public int ShipperId { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PicturePath")]
			public string PicturePath { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "0身份证正面1反面2手持")]
			[Column("Idtype")]
			public int Idtype { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

    }
  }      
}
