﻿using SemnanFlix.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace SemnanFlix.ViewModels.Department
{
    public class DepartmentViewModel : EntityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public bool IsDirecting { get; set; }

        public int PeopleCount { get; set; }
    }
}
