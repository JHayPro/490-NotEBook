#pragma checksum "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2193ddf5ea7e1bbab8c7b5b2c11bb84725284629"
// <auto-generated/>
#pragma warning disable 1591
namespace NotEBookWeb.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-12 col-md-12 col-lg-9");
            __builder.OpenComponent<NotEBookWeb.Controls.Calander>(2);
            __builder.AddAttribute(3, "DayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<NotEBookWeb.Models.CalanderDay>)((day) => (__builder2) => {
#nullable restore
#line 7 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor"
              
                string currentDayClass = day.Date == DateTime.Now.Date ? "current-day" : "";
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor"
             if (!day.isEmpty)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "navbar-text" + " " + (
#nullable restore
#line 13 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor"
                                         currentDayClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(6, "h3");
                __builder2.AddAttribute(7, "class", "font-weight-bold day");
                __builder2.AddContent(8, 
#nullable restore
#line 15 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor"
                                                      day.DayNum

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 30 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Todo.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
