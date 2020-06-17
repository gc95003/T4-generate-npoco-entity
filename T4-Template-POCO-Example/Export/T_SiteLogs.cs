using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_SiteLogs.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_SiteLogsMetadata))]
	[PrimaryKey("LogID")]
	[TableName("[dbo].[T_SiteLogs]")]
    public class T_SiteLogs 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_SiteLogsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("LogID")]
			public int Id { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHandled")]
			public bool IsHandled { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("LogThread")]
			public string LogThread { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("LogLevel")]
			public string LogLevel { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("LogLogger")]
			public string LogLogger { get; set; }

			[StringLength(4000, ErrorMessage = "{0}不能超过4000个字符！")]
			
			[Display(Name = "")]
			[Column("LogMessage")]
			public string LogMessage { get; set; }

			[StringLength(2000, ErrorMessage = "{0}不能超过2000个字符！")]
			
			[Display(Name = "")]
			[Column("LogException")]
			public string LogException { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("LogDate")]
			public DateTime LogDate { get; set; }

    }
  }      
}
