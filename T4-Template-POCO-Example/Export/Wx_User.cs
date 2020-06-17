using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a Wx_User.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(Wx_UserMetadata))]
	[PrimaryKey("ID")]
	[TableName("[dbo].[Wx_User]")]
    public class Wx_User 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class Wx_UserMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ID")]
			public int Id { get; set; }

			[StringLength(35, ErrorMessage = "{0}不能超过35个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("OpenID")]
			public string OpenID { get; set; }

			[StringLength(16, ErrorMessage = "{0}不能超过16个字符！")]
			
			[Display(Name = "")]
			[Column("IP")]
			public string IP { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "头像")]
			[Column("WXAvatarUrl")]
			public string WXAvatarUrl { get; set; }

			[StringLength(6, ErrorMessage = "{0}不能超过6个字符！")]
			
			[Display(Name = "性别")]
			[Column("WXGender")]
			public string WXGender { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "昵称")]
			[Column("WXnickName")]
			public string WXnickName { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "创建时间")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否删除")]
			[Column("IsDel")]
			public bool IsDel { get; set; }

			
			
			[Display(Name = "最后更新时间")]
			[Column("LastTime")]
			public DateTime? LastTime { get; set; }

			
			
			[Display(Name = "0普通用户1管理员")]
			[Column("UserType")]
			public int? UserType { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "微信默认手机号")]
			[Column("Tel")]
			public string Tel { get; set; }

			[StringLength(550, ErrorMessage = "{0}不能超过550个字符！")]
			
			[Display(Name = "简介")]
			[Column("WXProfiles")]
			public string WXProfiles { get; set; }

			
			
			[Display(Name = "生日")]
			[Column("WXBirthday")]
			public DateTime? WXBirthday { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "省")]
			[Column("ProvinceID")]
			public string ProvinceID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "市")]
			[Column("CityID")]
			public string CityID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "用户处理：0 不做处理 1 禁言")]
			[Column("Handle")]
			public int Handle { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "小程序授权类型：0物流车1会议2乘用车")]
			[Column("AuthorizationType")]
			public int AuthorizationType { get; set; }

    }
  }      
}
