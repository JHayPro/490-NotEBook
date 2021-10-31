#pragma checksum "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\DateComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4661c8af328f34be049f14ec3bd3f4c37adcf227"
// <auto-generated/>
#pragma warning disable 1591
namespace NotEBookWeb.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\DateComponent.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class DateComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h5");
            __builder.AddAttribute(1, "class", "text-left");
            __builder.AddContent(2, 
#nullable restore
#line 4 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\DateComponent.razor"
                        currentDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\DateComponent.razor"
                                     currentTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\DateComponent.razor"
       
    string currentDate, currentTime;
    Timer aTimer;

    protected override void OnInitialized()
    {
        currentDate = DateTime.Now.ToShortDateString();
        currentTime = DateTime.Now.ToShortTimeString();
        aTimer = new Timer(Tick, null, 0, 1000);
    }

    private void Tick(object _)
    {
        currentDate = DateTime.Now.ToShortDateString();
        currentTime = DateTime.Now.ToShortTimeString();
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        aTimer?.Dispose();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
