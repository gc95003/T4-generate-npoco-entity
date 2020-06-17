using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Topic_List.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(Topic_ListMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[Topic_List]")]
    public class Topic_List 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class Topic_ListMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("ClassID")]
			public int? ClassID { get; set; }

			
			
			[Display(Name = "")]
			[Column("Area")]
			public int? Area { get; set; }

			[StringLength(150, ErrorMessage = "{0}不能超过150个字符！")]
			
			[Display(Name = "")]
			[Column("CarName")]
			public string CarName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CarShortName")]
			public string CarShortName { get; set; }

			[StringLength(3000, ErrorMessage = "{0}不能超过3000个字符！")]
			
			[Display(Name = "")]
			[Column("CarInfo")]
			public string CarInfo { get; set; }

			
			
			[Display(Name = "")]
			[Column("DongLi")]
			public int? DongLi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianChi")]
			public string DianChi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianJi")]
			public string DianJi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ShiShu")]
			public string ShiShu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("PaiLian")]
			public string PaiLian { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ChongDian")]
			public string ChongDian { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ChiChun")]
			public string ChiChun { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("HaoDian")]
			public string HaoDian { get; set; }

			
			
			[Display(Name = "")]
			[Column("JiBie")]
			public int? JiBie { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("XuHang")]
			public int XuHang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ZhiBao")]
			public string ZhiBao { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hit")]
			public int? Hit { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Mhits")]
			public int Mhits { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("LunJu")]
			public string LunJu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ZhouJu")]
			public string ZhouJu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianYa")]
			public string DianYa { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("GongLv")]
			public string GongLv { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("NvJu")]
			public string NvJu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("BzDianYa")]
			public string BzDianYa { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("YongLiang")]
			public string YongLiang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DCGongLv")]
			public string DCGongLv { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("GlMiDu")]
			public string GlMiDu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("NlMiDu")]
			public string NlMiDu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DCShuMu")]
			public string DCShuMu { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CheSuJiBie")]
			public int CheSuJiBie { get; set; }

			
			
			[Display(Name = "")]
			[Column("ListedDate")]
			public DateTime? ListedDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("Price")]
			public decimal? Price { get; set; }

			
			
			[Display(Name = "")]
			[Column("MaxPrice")]
			public decimal? MaxPrice { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyPrice")]
			public decimal? CompanyPrice { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsListed")]
			public bool IsListed { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsSubsidy")]
			public bool IsSubsidy { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDutyFree")]
			public bool IsDutyFree { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ProductionStatus")]
			public int ProductionStatus { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("SubsidyBrief")]
			public string SubsidyBrief { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public bool IsHot { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsRecommend")]
			public bool IsRecommend { get; set; }

			
			
			[Display(Name = "")]
			[Column("BrandID")]
			public int? BrandID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FactoryID")]
			public int FactoryID { get; set; }

			
			
			[Display(Name = "")]
			[Column("CategoryID")]
			public int? CategoryID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleTypeID")]
			public int VehicleTypeID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ForumID")]
			public int ForumID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsReleased")]
			public byte IsReleased { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsShow")]
			public byte? IsShow { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyID")]
			public int? CompanyID { get; set; }

			
			
			[Display(Name = "")]
			[Column("YearID")]
			public byte? YearID { get; set; }

			
			
			[Display(Name = "1私家车2网约车")]
			[Column("CarUseType")]
			public int? CarUseType { get; set; }

    }
  }      
}
