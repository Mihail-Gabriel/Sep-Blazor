#pragma checksum "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78405d82917a96b74ef878a4e31ccece856cc79e"
// <auto-generated/>
#pragma warning disable 1591
namespace Sep3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Sep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\_Imports.razor"
using Sep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
using Sep3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
using Sep3.HttpServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Branches")]
    public partial class Branches : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Branch</h3>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "branching");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Policy", "SecurityLevel2");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-4");
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "type", "button");
                __builder2.AddAttribute(14, "class", "branchbtn");
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                                                  NavigateToAddBranch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "href", "/AddBranch");
                __builder2.AddContent(17, "Create new Branch");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.AddMarkupContent(19, "<div class=\"row\"><h3>Choose your branch</h3></div>\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
#nullable restore
#line 25 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
             if (branchesToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 30 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
            }
            else if (!branchesToShow.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>Currently there are no branches. Please add some.</em></p>");
#nullable restore
#line 36 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.OpenElement(26, "thead");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "<th>Theme</th>\n                        ");
            __builder.AddMarkupContent(29, "<th>Branch</th>\n                        ");
            __builder.AddMarkupContent(30, "<th>Location</th>\n                        ");
            __builder.AddMarkupContent(31, "<th>Menu</th>\n                        ");
            __builder.AddMarkupContent(32, "<th>Book a table</th>\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(33);
            __builder.AddAttribute(34, "Policy", "SecurityLevel2");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "<th>Remove Branch</th>\n                            ");
                __builder2.AddMarkupContent(37, "<th>Add food</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n\n                    ");
            __builder.OpenElement(39, "tbody");
#nullable restore
#line 55 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                     foreach (var item in branchesToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "tr");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 58 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                 item.theme

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 59 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                 item.branchName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 60 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                 item.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                            ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                                    () => GoToBranch(item.branchId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<i class=\"oi oi-list\" style=\"color:#17a2b8\">Menu</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.OpenElement(55, "td");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                                    () => GoToBooking(item.branchId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "<i class=\"oi oi-list\" style=\"color:#17a2b8\">Book a table</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(60);
            __builder.AddAttribute(61, "Policy", "SecurityLevel2");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(63, "td");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                                        () => RemoveBranch(item.branchId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(66, "<i class=\"oi oi-trash\">Remove</i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n                                ");
                __builder2.OpenElement(68, "td");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                                                        () => AddFood(item.branchId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(71, "<i class=\"oi oi-plus\">Add food</i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Branches.razor"
       
    private IList<Branch> branches;
    private IList<Branch> branchesToShow;
    
    protected override async Task OnInitializedAsync()
    {
        branches = await BranchService.GetBranchesAsync();
        branchesToShow = branches;
    }
    
    public void GoToBranch(int id)
    {
        Branch branch = branches.First(b => b.branchId == id);
        NavigationManager.NavigateTo($"BranchMenu/{id}");
    }
    
    public void GoToBooking(int id)
    {
        
        NavigationManager.NavigateTo($"Booking/{id}");
    }

    public async Task RemoveBranch(int id)
    {
        Branch toRemove = branches.First(b => b.branchId == id);
        await BranchService.RemoveBranchAsync(id);
        branches.Remove(toRemove);
        branchesToShow.Remove(toRemove);
    }

    void NavigateToAddBranch()
    {
        NavigationManager.NavigateTo("AddBranch");
    }

    private void AddFood(int id)
    {
        Branch branch = branches.First(b => b.branchId == id);
        NavigationManager.NavigateTo($"AddFood/{id}");
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBranchService BranchService { get; set; }
    }
}
#pragma warning restore 1591
