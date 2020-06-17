using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_ShipperCargoRoute.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(ShipperCargoRouteMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_ShipperCargoRoute]")]
    public class T_ShipperCargoRoute 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class ShipperCargoRouteMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货源线路id")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "添加顺序")]
			[Column("Number")]
			public int Number { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "货源id")]
			[Column("CargoId")]
			public int CargoId { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "地址类型：1装货 2卸货")]
			[Column("AddrType")]
			public int AddrType { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "省")]
			[Column("Province")]
			public string Province { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "市")]
			[Column("City")]
			public string City { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("District")]
			public string District { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AddrName")]
			public string AddrName { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "小区楼层")]
			[Column("Address")]
			public string Address { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "纬度")]
			[Column("Latitude")]
			public decimal Latitude { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "经度")]
			[Column("Longitude")]
			public decimal Longitude { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

    }
  }      
}
