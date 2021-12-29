// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ElSerajElMoneer.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using ElSerajElMoneer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/_Imports.razor"
using ElSerajElMoneer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
using ElSerajElMoneer.Data.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taghredat")]
    public partial class Taghredat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 508 "/Users/mahyoussef/projects/ElSerajElMoneer/ElSerajElMoneer/Client/Pages/Taghredat.razor"
       
    private List<TaghredatElSeraResponse> taghredatElSera;
    private MetaDataResponse metaDataResponse;
    private string downloadUrl = "api/TaghredatElSera/download";
    private int currentPage = 1;
    private int pageSize = 6;
    private bool isFirstPage() => currentPage == 1;
    private bool hasNotNext;
    private bool hasNotPrevious;
    protected override async Task OnInitializedAsync()
    {
        taghredatElSera = new List<TaghredatElSeraResponse>();
        try
        {
            await GetAllTaghredat(currentPage, pageSize);
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }
    private async Task GetAllTaghredat(int currentPage, int pageSize)
    {
        var response = await Http.GetAsync(
                $"api/taghredatelsera/?pageNumber={currentPage}&pageSize={pageSize}");

        var headers = response.Headers;
        metaDataResponse = JsonSerializer.Deserialize<MetaDataResponse>
        (headers.FirstOrDefault(h => h.Key.Equals("x-pagination")).Value.FirstOrDefault());

        hasNotNext = !metaDataResponse.HasNext;
        hasNotPrevious = !metaDataResponse.HasPrevious;
        taghredatElSera = await response.Content.ReadFromJsonAsync<List<TaghredatElSeraResponse>>();
    }
    private async Task GetNextPagedTaghredat()
    {
        currentPage++;
        await GetAllTaghredat(currentPage, pageSize);
    }
    private async Task GetPreviousPagedTaghredat()
    {
        currentPage--;
        await GetAllTaghredat(currentPage, pageSize);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
