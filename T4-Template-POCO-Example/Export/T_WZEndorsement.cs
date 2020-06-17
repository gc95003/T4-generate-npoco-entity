using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_WZEndorsement.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_WZEndorsementMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_WZEndorsement]")]
    public class T_WZEndorsement 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_WZEndorsementMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "车牌号")]
			[Column("CarNo")]
			public string CarNo { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "违章时间")]
			[Column("VioTime")]
			public string VioTime { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "违章地址")]
			[Column("VioAddress")]
			public string VioAddress { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "违章行为")]
			[Column("VioAction")]
			public string VioAction { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "违章罚款")]
			[Column("VioFine")]
			public string VioFine { get; set; }

			[StringLength(2, ErrorMessage = "{0}不能超过2个字符！")]
			
			[Display(Name = "违章记分")]
			[Column("VioScore")]
			public string VioScore { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "违章所在城市名称")]
			[Column("VioCityName")]
			public string VioCityName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "违章所在城市代码，同全国标准的行政区划代码")]
			[Column("VioCityNo")]
			public string VioCityNo { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "违法代码")]
			[Column("VioCode")]
			public string VioCode { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "采集机构")]
			[Column("ColOrgan")]
			public string ColOrgan { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "决定书编号")]
			[Column("DecisionNum")]
			public string DecisionNum { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MonitorNum")]
			public string MonitorNum { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			
			[Display(Name = "处理标记，返回值：1：未处理 未缴费 2：已处理 未缴费 3：已处理 已缴费")]
			[Column("HandleSign")]
			public string HandleSign { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "处理编号 在线处理时，传该编号。")]
			[Column("HandleNum")]
			public string HandleNum { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			
			[Display(Name = "在线处理，返回值： 1：可以处理 2：不支持处理 为空或不存在结果时，默认为：不支持处理。")]
			[Column("OnlineHandle")]
			public string OnlineHandle { get; set; }

    }
  }      
}
