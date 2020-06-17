using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Special.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(SpecialMetadata))]
	[PrimaryKey("SpecialID")]
	[TableName("[dbo].[T_Special]")]
    public class T_Special 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class SpecialMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SpecialID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SpecialName")]
			public string SpecialName { get; set; }

			[StringLength(2000, ErrorMessage = "{0}不能超过2000个字符！")]
			
			[Display(Name = "")]
			[Column("SpecialInfo")]
			public string SpecialInfo { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("BigPhoto")]
			public string BigPhoto { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsReleased")]
			public bool IsReleased { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsRecommend")]
			public byte IsRecommend { get; set; }

			[StringLength(2000, ErrorMessage = "{0}不能超过2000个字符！")]
			
			[Display(Name = "")]
			[Column("Lead")]
			public string Lead { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TplID")]
			public int TplID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("LeadPhoto")]
			public string LeadPhoto { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Banner")]
			public string Banner { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Background")]
			public string Background { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MarginTop")]
			public int MarginTop { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("TypeID")]
			public int TypeID { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("BgColor")]
			public string BgColor { get; set; }

    }
  }      
}
