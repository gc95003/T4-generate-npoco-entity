using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WZList.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(WZListMetadata))]
	[PrimaryKey("CarNo")]
	[TableName("[dbo].[T_WZList]")]
    public class T_WZList 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class WZListMetadata{
			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车牌号")]
			[Column("CarNo")]
			public string Id { get; set; }

			[StringLength(2, ErrorMessage = "{0}不能超过2个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "01:大车02:小车51:新能源大车52:新能源小车26:香港出入境（只有广东支持）27:澳门出入境（只有广东支持）15:挂车（只有广东支持）")]
			[Column("CarType")]
			public string CarType { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "发动机号")]
			[Column("EngineNumber")]
			public string EngineNumber { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车架号")]
			[Column("FrameNumber")]
			public string FrameNumber { get; set; }

			[StringLength(10, ErrorMessage = "{0}不能超过10个字符！")]
			
			[Display(Name = "违章条数")]
			[Column("VioNum")]
			public string VioNum { get; set; }

			[StringLength(10, ErrorMessage = "{0}不能超过10个字符！")]
			
			[Display(Name = "违章罚款合计")]
			[Column("FineTotal")]
			public string FineTotal { get; set; }

			[StringLength(2, ErrorMessage = "{0}不能超过2个字符！")]
			
			[Display(Name = "违章积分合计")]
			[Column("IntegralTotal")]
			public string IntegralTotal { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "查询次数")]
			[Column("QueryNum")]
			public int QueryNum { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "修改时间")]
			[Column("UpdateTime")]
			public DateTime UpdateTime { get; set; }

    }
  }      
}
