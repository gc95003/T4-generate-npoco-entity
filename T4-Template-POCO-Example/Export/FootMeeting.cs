using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a FootMeeting.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(FootMeetingMetadata))]
	[PrimaryKey("id")]
	[TableName("[dbo].[FootMeeting]")]
    public class FootMeeting 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class FootMeetingMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "自增长主键")]
			[Column("id")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户id")]
			[Column("UserId")]
			public int UserId { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MeetingCode")]
			public string MeetingCode { get; set; }

    }
  }      
}
