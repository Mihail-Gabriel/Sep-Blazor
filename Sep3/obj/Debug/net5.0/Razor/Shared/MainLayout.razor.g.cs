#pragma checksum "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efff155824f0a3750465c028aa6a9c3b0a8a98e9"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-6nr6ea4f16");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "topbar");
            __builder.AddAttribute(5, "b-6nr6ea4f16");
            __builder.OpenComponent<Sep3.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddAttribute(10, "b-6nr6ea4f16");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
