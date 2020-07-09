using BlazorQuest.Domain.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQuest.WASM.Pages
{
    public partial class RadioBinding
    {
        JobTitle JobTitle { get; set; } = JobTitle.Dev;
        OfficeLocation OfficeLocation { get; set; } = OfficeLocation.Nashville;
    }
}
