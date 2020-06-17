using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_OperatorActivitiesCar.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(OperatorActivitiesCarMetadata))]
	[PrimaryKey("")]
	[TableName("[dbo].[T_OperatorActivitiesCar]")]
    public class T_OperatorActivitiesCar 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class OperatorActivitiesCarMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			
			
			[Display(Name = "")]
			[Column("ActivityId")]
			public int? ActivityId { get; set; }

			
			
			[Display(Name = "")]
			[Column("CarID")]
			public int? CarID { get; set; }

    }
  }      
}
