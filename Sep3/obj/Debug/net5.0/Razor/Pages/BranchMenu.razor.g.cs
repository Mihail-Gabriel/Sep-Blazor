#pragma checksum "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e92065e5145a35df9f48abd979c5918e3fec17fc"
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
#line 3 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
using Sep3.HttpServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
using Sep3.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BranchMenu/{id}")]
    public partial class BranchMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Restaurant ");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                branchToShow.branchName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, "Location ");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
              branchToShow.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
 if (foodList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<table class=\"table\" style=\"width:100%\"><thead><tr><th>Meal name</th>\r\n            <th>Price</th>\r\n            <th>Add To Basket</th></tr></thead></table>");
#nullable restore
#line 29 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 31 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
 foreach (var item in foodList)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "table_food");
            __builder.AddAttribute(13, "style", "width:100%");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "colspan");
            __builder.AddContent(16, 
#nullable restore
#line 35 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                    item.foodName.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 36 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
         item.foodPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " kr");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                            () => AddToBasket(item.foodName, item.foodPrice)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<i class=\"oi oi-plus\" style=\"color:green\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
       
    [Parameter]
    public string id { get; set; }
    
    public Branch branchToShow = new Branch();
    public List<Food> foodList = new List<Food>();


    private int branchId;
    
    protected override async void OnInitialized()
    {
        branchId = Int32.Parse(id);
        branchToShow = await BranchService.GetBranchByIdAsync(branchId);
    }
    protected override async Task OnInitializedAsync()
    {
        foodList = await BranchService.GetFood(branchId);
        
    }


    private void AddToBasket(string itemFoodName, double itemFoodPrice)
    {
        throw new NotImplementedException();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBranchService BranchService { get; set; }
    }
}
#pragma warning restore 1591
