using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a ZhanHui.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ZhanHuiMetadata))]
	[PrimaryKey("Exhib_ID")]
	[TableName("[dbo].[ZhanHui]")]
    public class ZhanHui 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ZhanHuiMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Exhib_ID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("E_Name")]
			public string E_Name { get; set; }

			
			
			[Display(Name = "")]
			[Column("E_BeginDate")]
			public DateTime? E_BeginDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("E_EndDate")]
			public DateTime? E_EndDate { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("E_Address")]
			public string E_Address { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("E_City")]
			public string E_City { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("E_ChengBan")]
			public string E_ChengBan { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("E_Company")]
			public string E_Company { get; set; }

			
			
			[Display(Name = "")]
			[Column("E_CityID")]
			public int? E_CityID { get; set; }

			
			
			[Display(Name = "")]
			[Column("TuiJian")]
			public int? TuiJian { get; set; }

			
			
			[Display(Name = "")]
			[Column("E_Flag")]
			public int? E_Flag { get; set; }

			
			
			[Display(Name = "")]
			[Column("E_CateID")]
			public int? E_CateID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsTop")]
			public byte IsTop { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AreaID")]
			public int AreaID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Forms")]
			public int Forms { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Scale")]
			public string Scale { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Website")]
			public string Website { get; set; }

    }
  }      
}
