using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MeetingSpeaker.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MeetingSpeakerMetadata))]
	[PrimaryKey("SpeakerID")]
	[TableName("[dbo].[T_MeetingSpeaker]")]
    public class T_MeetingSpeaker 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MeetingSpeakerMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SpeakerID")]
			public int Id { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("GuestName")]
			public string GuestName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Position1")]
			public string Position1 { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Position2")]
			public string Position2 { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Theme")]
			public string Theme { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("AvatarUrl")]
			public string AvatarUrl { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("LinkUrl")]
			public string LinkUrl { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("ArticleLinkUrl")]
			public string ArticleLinkUrl { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("PPTLinkUrl")]
			public string PPTLinkUrl { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MeetingID")]
			public int MeetingID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("GroupID")]
			public int GroupID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public byte Rank { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsEnabled")]
			public bool IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

    }
  }      
}
