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
#line 2 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Register.razor"
using Sep3.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\Register.razor"
       

    private string username;
    private string password;
    private string number;
    private string address;
    private string city;
    private string errorMessage;

    public async Task PerformRegister()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateRegister(username, password, 
              number, address, city);
          NavigationManager.NavigateTo("/Host");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
