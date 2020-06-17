using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_Questionnaire.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_QuestionnaireMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[T_Questionnaire]")]
    public class T_Questionnaire 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_QuestionnaireMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Title")]
			public string Title { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Nickname")]
			public string Nickname { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			
			[Display(Name = "")]
			[Column("Content")]
			public string Content { get; set; }

			
			
			[Display(Name = "")]
			[Column("cdate")]
			public DateTime? Cdate { get; set; }

    }
  }      
}
