﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//
using System.ComponentModel.DataAnnotations;

namespace Leaves.Student.Models
{
    public enum ClassNameEnum
    {
        [Display(Name = "未分配")]
        None,
        [Display(Name = "一年级")]
        FirstGrade,
        [Display(Name = "二年级")]
        SecondGrade,
        [Display(Name = "三年级")]
        GradeThree
    }
}
