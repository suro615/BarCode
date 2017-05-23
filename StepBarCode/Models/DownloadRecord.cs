/*************************************************
 * Copyright (C), 1996-2017, STEP. Co., Ltd.
 * Project name: StepBarCode.Models
 * File name: DownloadRecord
 * Version: 
 * Author: pc
 * Date: 2017/5/16 14:16:27
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
    public class DownloadRecord
    {
        [Key]
        public string ID { get; set; }
        public string SoftWareCodeID { get; set; }

        public string HardWareVersion { get; set; }

        [Required]
        [Display(Name = "下载者")]
        public string DownLoader { get; set; }

        [Required]
        [Display(Name = "下载日期")]
        public DateTime DownLoadedTime { get; set; }

        [ForeignKey("SoftWareCodeID")]
        public virtual SoftWareCode SoftWareCode { get; set; }
    }
}