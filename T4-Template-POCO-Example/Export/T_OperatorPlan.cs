using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorPlan.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_OperatorPlanMetadata))]
	[PrimaryKey("PlanId")]
	[TableName("[dbo].[T_OperatorPlan]")]
    public class T_OperatorPlan 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_OperatorPlanMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PlanId")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OperatorID")]
			public int OperatorID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleID")]
			public int VehicleID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "期数")]
			[Column("Periods")]
			public int Periods { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "押金")]
			[Column("Deposit")]
			public int Deposit { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "月租")]
			[Column("Monthly")]
			public int Monthly { get; set; }

			
			
			[Display(Name = "是否推荐")]
			[Column("IsRecommend")]
			public bool? IsRecommend { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			
			
			[Display(Name = "修改时间")]
			[Column("LastTime")]
			public DateTime? LastTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsDel")]
			public bool? IsDel { get; set; }

    }
  }      
}
