#pragma checksum "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d88e93cdff968e14da7c4814bfe07ab0475d4b9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using ChartJs.Blazor.ChartJS.RadarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MainDashboardCharacters")]
    public partial class MainDashboardCharacters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/MainDashboardCharacters.razor"
       
    private List<Characters> characters;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CharacterService CharService { get; set; }
    }
}
#pragma warning restore 1591