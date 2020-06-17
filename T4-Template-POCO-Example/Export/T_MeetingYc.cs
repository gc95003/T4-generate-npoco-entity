using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MeetingYc.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_MeetingYcMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_MeetingYc]")]
    public class T_MeetingYc 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_MeetingYcMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("MeetingID")]
			public int? MeetingID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DayTime")]
			public string DayTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Time")]
			public string Time { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Content")]
			public string Content { get; set; }

    }
  }      
}
