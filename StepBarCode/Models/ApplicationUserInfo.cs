/*************************************************
 * Copyright (C), 1996-2017, STEP. Co., Ltd.
 * Project name: StepBarCode.Models
 * File name: ApplicationUserWeChat
 * Version: 
 * Author: pc
 * Date: 2017/5/16 11:44:42
 * Description: 
**************************************************
 * History://modification 
 * 1.<author> <time> <version> <desc>
*************************************************/

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StepBarCode.Models
{
    public class ApplicationUserInfo
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "微信OpenID")]
        public string OpenID { get; set; }

        [StringLength(20)]
        [Display(Name = "昵称")]
        public string NickName { get; set; }
        [StringLength(20)]
        [Display(Name = "真是姓名")]
        public string RealName { get; set; }
        [StringLength(15)]
        [Display(Name = "手机号码")]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        [Display(Name = "邮箱")]
        public string Mail { get; set; }
        
        public string ApplicationUserID { get; set; }
        [ForeignKey("ApplicationUserID")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}