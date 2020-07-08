using BlazorQuest.Component.Services;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorQuest.WASM.Pages
{
    public partial class MovieSearch
    {
        [Inject]
        public IMovieSearchService client { get; set; }
        public string SearchText { get; set; }

        public void WriteToConsole(ChangeEventArgs e)
        {
            SearchText = e.Value.ToString();
            Console.WriteLine(SearchText);
        }
    }
}