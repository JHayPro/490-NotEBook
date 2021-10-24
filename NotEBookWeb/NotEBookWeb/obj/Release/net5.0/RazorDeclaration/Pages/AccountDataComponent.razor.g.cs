// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NotEBookWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientele_sheet")]
    public partial class AccountDataComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\AccountDataComponent.razor"
      

    List<ClientInfoModel> ClientList;
    int selectedGroup = 0;
    int selectedLocationId = 0;
    int currID = 0;
    int removeIndex;
    bool isEditing = false;
    string cityFilter = "0";

    protected override void OnInitialized()
    {
        base.OnInitialized();

        ClientList = new List<ClientInfoModel>() {
        new ClientInfoModel
        {

            Client = "Lenny Kramnik",
            Parent = "Alla Kramnik",
            Grade = 6,
            Subjects = new List<string>(){ "Math", "English", "Coding" },
            isInHome = true,
            location = new Location
            {
                StreetAddress = "5503 Evita Ct",
                City = "Agoura Hills",
                State = "CA",
                Country = "United States",
                Zipcode = "91362"
            }

        } };

    }

    void toggleEditing()
    {
        isEditing = !isEditing;
    }

    void setFilter()
    {

    }

    void addClient() => ClientList.Add(new ClientInfoModel
    {
        Client = "Child",
        Parent = "Parent",
        Grade = 0,
        Subjects = new List<string>() { "Subject1", "Subject2", "Subject3" },
        isInHome = true,
        location = new Location
        {
            StreetAddress = "123 Easy St",
            City = "City",
            State = "State",
            Country = "United States",
            Zipcode = "12345"
        }
    });

    void removeClient()
    {
        if (0 < removeIndex && removeIndex <= ClientList.Count)
        {
            ClientList.RemoveAt(removeIndex - 1);
        }
    }

    #region "View Model"

    class ClientInfoModel
    {
        public string Client { get; set; }
        public string Parent { get; set; }
        public int Grade { get; set; }
        public List<string> Subjects;
        public bool isInHome { get; set; }
        public Location location;
    }

    class Location
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
    }

    #endregion

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
