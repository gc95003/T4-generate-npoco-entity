using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_RepairParts.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(RepairPartsMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_RepairParts]")]
    public class T_RepairParts 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class RepairPartsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "配件名称")]
			[Column("PartsName")]
			public string PartsName { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "绑定品牌")]
			[Column("RelationBrands")]
			public string RelationBrands { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "关联维修")]
			[Column("RelationMaintainers")]
			public string RelationMaintainers { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "关联车系")]
			[Column("RelationVehicleSeries")]
			public string RelationVehicleSeries { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("EditorContent")]
			public string EditorContent { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("BasicDetails")]
			public string BasicDetails { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			
			
			[Display(Name = "修改时间")]
			[Column("Updatetime")]
			public DateTime? Updatetime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "配件标签")]
			[Column("Tips")]
			public string Tips { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "人工价")]
			[Column("LaborPrice")]
			public decimal LaborPrice { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "配件价")]
			[Column("PartsPrice")]
			public decimal PartsPrice { get; set; }

			[StringLength(9, ErrorMessage = "{0}不能超过9个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "门店市场价格")]
			[Column("StorePrice")]
			public decimal StorePrice { get; set; }

    }
  }      
}
