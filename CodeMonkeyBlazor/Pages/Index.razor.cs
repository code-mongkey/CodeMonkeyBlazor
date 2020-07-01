using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CodeMonkeyBlazor.Pages
{
    public partial class Index
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected override void OnInitialized()
        {

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeAsync<object>("RunCarousel");
        }
    }
}
