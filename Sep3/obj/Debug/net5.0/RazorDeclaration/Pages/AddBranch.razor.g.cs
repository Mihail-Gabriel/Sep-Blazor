// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sep3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Sep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iliya\RiderProjects\Sep3\Sep3\_Imports.razor"
using Sep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Pages\AddBranch.razor"
using Sep3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Pages\AddBranch.razor"
using Sep3.HttpServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Pages\AddBranch.razor"
           [Authorize(Policy = "SecurityLevel2")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddBranch")]
    public partial class AddBranch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Pages\AddBranch.razor"
       
    private Branch newBranchItem = new Branch();
    private string menuName;
    
    private async Task AddNewBranch()
    {
        newBranchItem.menu = await BranchService.GetMenuByNameAsync(menuName);

        await BranchService.AddBranchAsync(newBranchItem);
        NavigationManager.NavigateTo("/Branches");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBranchService BranchService { get; set; }
    }
}
#pragma warning restore 1591
