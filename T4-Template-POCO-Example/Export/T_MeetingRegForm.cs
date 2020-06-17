using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_MeetingRegForm.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(MeetingRegFormMetadata))]
	[PrimaryKey("MeetingID")]
	[TableName("[dbo].[T_MeetingRegForm]")]
    public class T_MeetingRegForm 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class MeetingRegFormMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MeetingID")]
			public int Id { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("MeetingName")]
			public string MeetingName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MeetingCode")]
			public string MeetingCode { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("GuestsName")]
			public string GuestsName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Position")]
			public string Position { get; set; }

			
			
			[Display(Name = "")]
			[Column("Sex")]
			public bool? Sex { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Mobile")]
			public string Mobile { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Email")]
			public string Email { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Invoice")]
			public string Invoice { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CompanyName")]
			public string CompanyName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Address")]
			public string Address { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsLunch")]
			public bool? IsLunch { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsDinner")]
			public bool? IsDinner { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsPaid")]
			public bool? IsPaid { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsAudit")]
			public bool? IsAudit { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsDeleted")]
			public bool? IsDeleted { get; set; }

			
			
			[Display(Name = "")]
			[Column("ParticipationType")]
			public byte? ParticipationType { get; set; }

			
			
			[Display(Name = "")]
			[Column("FormTypes")]
			public byte? FormTypes { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MainProducts")]
			public string MainProducts { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("SponsorType")]
			public string SponsorType { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Hotel")]
			public string Hotel { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("HotelRoom")]
			public string HotelRoom { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("Vehicle")]
			public string Vehicle { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("FlightOrTrain")]
			public string FlightOrTrain { get; set; }

			
			
			[Display(Name = "")]
			[Column("ArrivalTime")]
			public DateTime? ArrivalTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("LeaveTime")]
			public DateTime? LeaveTime { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("AdminID")]
			public int? AdminID { get; set; }

			
			
			[Display(Name = "")]
			[Column("TicketID")]
			public int? TicketID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Appraise")]
			public string Appraise { get; set; }

			
			
			[Display(Name = "")]
			[Column("ManNum")]
			public int? ManNum { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Commodity")]
			public string Commodity { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ExpressCompany")]
			public string ExpressCompany { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("OrderID")]
			public string OrderID { get; set; }

			
			
			[Display(Name = "")]
			[Column("UserID")]
			public int? UserID { get; set; }

    }
  }      
}
