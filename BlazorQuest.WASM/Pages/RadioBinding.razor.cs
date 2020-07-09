using BlazorQuest.Domain.Enums;

namespace BlazorQuest.WASM.Pages
{
    public partial class RadioBinding
    {
        JobTitle JobTitle { get; set; } = JobTitle.Dev;
        OfficeLocation OfficeLocation { get; set; } = OfficeLocation.TN;
    }
}
