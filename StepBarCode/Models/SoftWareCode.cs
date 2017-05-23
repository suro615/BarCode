/*************************************************
 * Copyright (C), 1996-2017, STEP. Co., Ltd.
 * Project name: StepBarCode.Models
 * File name: SoftWareCode
 * Version: 
 * Author: pc
 * Date: 2017/5/16 13:47:18
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
    public class SoftWareCode
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "程序名称")]
        public string SoftName { get; set; }

        [Required]
        [Display(Name = "文件大小")]
        public int FileSize { get; set; }

        [Required]
        [Display(Name = "硬件版本")]
        public int HardWareVersion { get; set; }

        [Required]
        [Display(Name = "是否可用")]
        public bool IsActived { get; set; }

        [Required]
        [Display(Name = "作者")]
        public string Writer { get; set; }

        [Required]
        [Display(Name = "上传者")]
        public string Uploader { get; set; }
        [Required]
        [Display(Name = "上传日期")]
        public DateTime UploadedTime { get; set; }

        [Required]
        [Display(Name = "下载次数")]
        public int DownloadNumber { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "备注信息")]
        public string Note { get; set; }
        
        [ForeignKey("Uploader")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}