using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarCompanyCar.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CarCompanyCarMetadata))]
	[PrimaryKey("RelatedID")]
	[TableName("[dbo].[T_CarCompanyCar]")]
    public class T_CarCompanyCar 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CarCompanyCarMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("RelatedID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CompanyID")]
			public int CompanyID { get; set; }

			
			
			[Display(Name = "")]
			[Column("CarID")]
			public int? CarID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("BrandID")]
			public int BrandID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SeriesID")]
			public int SeriesID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleTypeID")]
			public int VehicleTypeID { get; set; }

			
			
			[Display(Name = "")]
			[Column("YearID")]
			public int? YearID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Mhits")]
			public int Mhits { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Hit")]
			public int Hit { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CheSuJiBie")]
			public int CheSuJiBie { get; set; }

			
			
			[Display(Name = "")]
			[Column("Price")]
			public decimal? Price { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ProductionStatus")]
			public int ProductionStatus { get; set; }

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

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsAudit")]
			public bool IsAudit { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsListed")]
			public bool IsListed { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDeleted")]
			public bool IsDeleted { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Sort")]
			public int Sort { get; set; }

			
			
			[Display(Name = "")]
			[Column("ListedDate")]
			public DateTime? ListedDate { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CarName")]
			public string CarName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CarShortName")]
			public string CarShortName { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("CarInfo")]
			public string CarInfo { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DongLi")]
			public int DongLi { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("JiBie")]
			public int JiBie { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ZhiBao")]
			public string ZhiBao { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianChi")]
			public string DianChi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ShiShu")]
			public string ShiShu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ChongDian")]
			public string ChongDian { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("HaoDian")]
			public string HaoDian { get; set; }

			
			
			[Display(Name = "")]
			[Column("XuHang")]
			public decimal? XuHang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ChiChun")]
			public string ChiChun { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("Photo")]
			public string Photo { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianYa")]
			public string DianYa { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DianJi")]
			public string DianJi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("GongLv")]
			public string GongLv { get; set; }

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

    }
  }      
}
