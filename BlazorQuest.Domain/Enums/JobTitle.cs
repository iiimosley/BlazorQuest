using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorQuest.Domain.Enums
{
    public enum JobTitle
    {
        [Display(Name="Developer")]
        Dev,
        [Display(Name="Quality Analyst")]
        QA,
        [Display(Name = "Delivery Manager")]
        DM,
        [Display(Name = "Product Designer")]
        PD
    }
}
