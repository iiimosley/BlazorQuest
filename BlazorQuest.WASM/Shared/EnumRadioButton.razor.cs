using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQuest.WASM.Shared
{
    public partial class EnumRadioButton<TEnum>
    {
        [Parameter]
        public TEnum EnumType { get; set; }
    }
}
