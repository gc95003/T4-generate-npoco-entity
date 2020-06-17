using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_PartsPhotos.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(PartsPhotosMetadata))]
	[PrimaryKey("PhotoID")]
	[TableName("[dbo].[T_PartsPhotos]")]
    public class T_PartsPhotos 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class PartsPhotosMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PartsID")]
			public int PartsID { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoUrl")]
			public string PhotoUrl { get; set; }

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
