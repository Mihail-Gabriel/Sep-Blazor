#pragma checksum "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212d22791271d4bd3d3d01b8bb7f8928cac3ca1c"
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
#line 2 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
using Sep3.HttpServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
using Sep3.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFood/{id}")]
    public partial class AddFood : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Food</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, " Food name/ description:<br> ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
                                                                                      food.foodName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => food.foodName = __value, food.foodName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, " Price: <br> ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
                                                                        food.foodPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => food.foodPrice = __value, food.foodPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "h3");
            __builder.AddAttribute(18, "class", "actions");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-outline-dark");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
                                                   AddNewFood

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "type", "button");
            __builder.AddContent(23, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\AddFood.razor"
       
    [Parameter]
    public string id { get; set; }
    
    private Food food = new Food();
    private Branch branch = new Branch();

    private int branchId ;
    protected override void OnParametersSet()
    {
        branchId = Int16.Parse(id);
    }

    private async Task AddNewFood()
    {
        
        branch = await BranchService.GetBranchByIdAsync(branchId);

        food.branch = branch;
        await BranchService.AddFoodToBranchAsync(food);
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
