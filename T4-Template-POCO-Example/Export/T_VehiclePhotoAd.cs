using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VehiclePhotoAd.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VehiclePhotoAdMetadata))]
	[PrimaryKey("PhotoID")]
	[TableName("[dbo].[T_VehiclePhotoAd]")]
    public class T_VehiclePhotoAd 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VehiclePhotoAdMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PhotoTitle")]
			public string PhotoTitle { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoPath")]
			public string PhotoPath { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PhotoSize")]
			public int PhotoSize { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RankType")]
			public byte RankType { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsEnabled")]
			public bool IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("EndTime")]
			public DateTime? EndTime { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			
			
			[Display(Name = "源id")]
			[Column("SourceID")]
			public int? SourceID { get; set; }

    }
  }      
}
