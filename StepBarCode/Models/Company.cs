/*************************************************
 * Copyright (C), 1996-2017, STEP. Co., Ltd.
 * Project name: StepBarCode.Models
 * File name: Company
 * Version: 
 * Author: pc
 * Date: 2017/5/16 11:31:57
 * Description: 
**************************************************
 * History://modification 
 * 1.<author> <time> <version> <desc>
*************************************************/

using System.ComponentModel.DataAnnotations;

namespace StepBarCode.Models
{
    public class Company
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }
        [StringLength(100)]
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "专用码")]
        public int FCode { get; set; }
        //public virtual ICollection<Customer> Customers { get; set; }
        //public virtual ICollection<CustMobile> CustMobiles { get; set; }
        //public virtual ICollection<ContractNo> ContractNos { get; set; }
    }
}