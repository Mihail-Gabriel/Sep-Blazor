#pragma checksum "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2635e51a5497e47194eb46ec3ca7adb1c95efd2"
// <auto-generated/>
#pragma warning disable 1591
namespace Sep3.Shared
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
#line 1 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
using Sep3.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
using Sep3.Authorization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark bg-dark fixed-top");
            __builder.AddAttribute(2, "b-lxvlsj4m2y");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-lxvlsj4m2y");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row align-items-center");
            __builder.AddAttribute(8, "b-lxvlsj4m2y");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 10 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
                         NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
                                                    ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "b-lxvlsj4m2y");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "navbar-toggler");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
                                                         ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-lxvlsj4m2y");
            __builder.AddMarkupContent(17, "<span class=\"navbar-toggler-icon\" b-lxvlsj4m2y></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "nav");
            __builder.AddAttribute(21, "b-lxvlsj4m2y");
            __builder.AddMarkupContent(22, "<li b-lxvlsj4m2y><a class=\"navbar-brand\" href b-lxvlsj4m2y>Sep3</a></li>\r\n                    ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item");
            __builder.AddAttribute(25, "b-lxvlsj4m2y");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "href", "Branches");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-lxvlsj4m2y></span> Branch\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.AddAttribute(34, "b-lxvlsj4m2y");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "Login");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-lock-unlocked\" aria-hidden=\"true\" b-lxvlsj4m2y></span> Login\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item");
            __builder.AddAttribute(43, "b-lxvlsj4m2y");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 29 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
                                                         input

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<input class=\"inputfield\" type=\"text\" placeholder=\"Search..\" b-lxvlsj4m2y>\r\n                            <span class=\"oi oi-magnifying-glass\" b-lxvlsj4m2y></span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "nav-item");
            __builder.AddAttribute(52, "b-lxvlsj4m2y");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "ConceptProofPage");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "<span class=\"oi oi-cart\" aria-hidden=\"true\" b-lxvlsj4m2y></span>Basket\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\iliya\RiderProjects\Sep3\Sep3\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string input;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
