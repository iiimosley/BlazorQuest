using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorQuest.WASM.Shared
{
    public partial class EnumRadioButton<TEnum>
    {
        [Parameter]
        public TEnum SelectedEnum { get; set; }
        [Parameter]
        public EventCallback<TEnum> SelectedEnumChanged { get; set; }
        
        string RadName { get => $"rad{typeof(TEnum).Name}";  }

        async Task BindRadioEnumValue(ChangeEventArgs e)
        {
            SelectedEnum = (TEnum)Enum.Parse(typeof(TEnum), e.Value.ToString());
            await SelectedEnumChanged.InvokeAsync(SelectedEnum);
        }
    }
}
