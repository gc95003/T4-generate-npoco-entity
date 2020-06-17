using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a PaChong.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(PaChongMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[PaChong]")]
    public class PaChong 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class PaChongMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("FirstCalss")]
			public string FirstCalss { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("TwoClass")]
			public string TwoClass { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("SpecificCalss")]
			public string SpecificCalss { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("EntName")]
			public string EntName { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Addr")]
			public string Addr { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Img")]
			public string Img { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Contact")]
			public string Contact { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Phone")]
			public string Phone { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("MobilePhone")]
			public string MobilePhone { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("HsCode")]
			public string HsCode { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Detail")]
			public string Detail { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("KeyWord")]
			public string KeyWord { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "")]
			[Column("Url")]
			public string Url { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("EntCode")]
			public string EntCode { get; set; }

			
			
			[Display(Name = "")]
			[Column("Time")]
			public DateTime? Time { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreatTime")]
			public DateTime? CreatTime { get; set; }

    }
  }      
}
