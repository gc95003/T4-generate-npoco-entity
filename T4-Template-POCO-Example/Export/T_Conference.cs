using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Conference.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ConferenceMetadata))]
	[PrimaryKey("ConferenceID")]
	[TableName("[dbo].[T_Conference]")]
    public class T_Conference 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ConferenceMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ConferenceID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ConferenceName")]
			public string ConferenceName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ConferenceType")]
			public int ConferenceType { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Summary")]
			public string Summary { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("BeginDate")]
			public DateTime BeginDate { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("EndDate")]
			public DateTime EndDate { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CityID")]
			public int CityID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsRecommend")]
			public bool IsRecommend { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CategoryID")]
			public int CategoryID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("ConferenceUrl")]
			public string ConferenceUrl { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsReleased")]
			public bool IsReleased { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TplID")]
			public int TplID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Logo")]
			public string Logo { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Banner")]
			public string Banner { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("SubBanner")]
			public string SubBanner { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Background")]
			public string Background { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
