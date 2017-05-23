using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace StepBarCode.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "权限名称")]
        public string Name { get; set; }
        [StringLength(50)]
        [Display(Name = "描述")]
        public string Description { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Display(Name = "公司名称")]
        public int CompanyID { get; set; }

        //[Display(Name = "部门名称")]
        //public int DepartmentID { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}