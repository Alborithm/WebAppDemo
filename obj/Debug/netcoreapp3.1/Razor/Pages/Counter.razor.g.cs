#pragma checksum "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7de702707dc40da4d4af1913743921112ab37b3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(10, "<h1>My Blozor Code dude!</h1>\r\n   My Name is : ");
            __builder.AddContent(11, 
#nullable restore
#line 11 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor"
                 myName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "     <br>\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor"
                  ClickMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Click Me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/gerardoalbor/Repositories/BlazorTest/WebApplication1/Pages/Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    [Parameter]
    public string myName { get; set; }

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

    private void ClickMe()
    {
        myName = "Albor";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591