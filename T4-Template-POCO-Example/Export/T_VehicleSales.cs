using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_VehicleSales.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(VehicleSalesMetadata))]
	[PrimaryKey("CarID")]
	[TableName("[dbo].[T_VehicleSales]")]
    public class T_VehicleSales 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class VehicleSalesMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CarID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("CarType")]
			public int? CarType { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CarName")]
			public string CarName { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsEnabled")]
			public int? IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("SalesNum")]
			public int? SalesNum { get; set; }

    }
  }      
}
