using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorQuest.Domain.Enums
{
    public enum OfficeLocation
    {
        [Display(Name = "Nashville")]
        TN,
        [Display(Name = "Jericho")]
        NY,
        [Display(Name = "Denver")]
        CO,
        [Display(Name = "Portland")]
        OR,
        [Display(Name = "Chicago")]
        IL
    }
}
