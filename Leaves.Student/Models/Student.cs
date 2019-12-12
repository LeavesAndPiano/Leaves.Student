using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//
using System.ComponentModel.DataAnnotations;
namespace Leaves.Student.Models
{
    public class Student
    {
        [Display(Name ="ID")]
        public int Id { get; set; }
        [Display(Name ="姓名")]
        [Required(ErrorMessage ="请输入姓名")]
        public string Name { get; set; }
        [Display(Name = "班级")]
        [Required(ErrorMessage = "请输入班级")]
        public ClassNameEnum? ClassName { get; set; }
        [Display(Name = "邮箱")]
        [Required(ErrorMessage = "请输入邮箱")]
        public string Email { get; set; }
        public string PhotoPato { get; set; }

        

    }
}
