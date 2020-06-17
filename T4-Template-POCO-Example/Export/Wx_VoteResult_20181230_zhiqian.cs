using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Wx_VoteResult_20181230_zhiqian.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(Wx_VoteResult_20181230_zhiqianMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[Wx_VoteResult_20181230_zhiqian]")]
    public class Wx_VoteResult_20181230_zhiqian 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class Wx_VoteResult_20181230_zhiqianMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int ID { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OpenID")]
			public string OpenID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OptionID")]
			public int OptionID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ClassID")]
			public int ClassID { get; set; }

			[StringLength(16, ErrorMessage = "{0}不能超过16个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

    }
  }      
}
