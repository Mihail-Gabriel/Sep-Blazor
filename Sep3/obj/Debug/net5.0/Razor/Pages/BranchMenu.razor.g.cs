#pragma checksum "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168c16f1cf3e69c5b55dd6f4960f0094948d4738"
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
#nullable restore
#line 5 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BranchMenu/{id}")]
    public partial class BranchMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "<h3>Restaurant </h3>\r\n    ");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "id", "h3restaurant");
            __builder.AddContent(6, 
#nullable restore
#line 16 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                            branchToShow.branchName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "h3");
            __builder.AddContent(9, "Location ");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                  branchToShow.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "h3");
            __builder.AddAttribute(13, "id", "h3location");
            __builder.AddContent(14, 
#nullable restore
#line 18 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                          branchToShow.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
     if (foodList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<p><em>Loading...</em></p>");
#nullable restore
#line 25 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddAttribute(18, "id", "menufood");
            __builder.AddAttribute(19, "style", "width:100%");
            __builder.AddMarkupContent(20, "<tr><th>Meal name</th>\r\n                <th>Price</th>\r\n                <th>Add To Basket</th></tr>");
#nullable restore
#line 36 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
             foreach (var item in foodList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddAttribute(23, "style", "width:100%");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "colspan");
            __builder.AddContent(26, 
#nullable restore
#line 39 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                                    item.foodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 40 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                         item.foodPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " kr");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Policy", "SecurityLevel1");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "td");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
                                                () => AddToBasket(item.foodName, item.foodPrice) 

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(38, "<i class=\"oi oi-plus\" style=\"color:green\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Flavius-Alin\Desktop\Git OWN branches\Sep-Blazor\Sep3\Pages\BranchMenu.razor"
       
    [Parameter]
    public string id { get; set; }

    public OrderFood OrderFood{ get; set; }
    public List<Food> basket = new List<Food>();
    public Branch branchToShow = new Branch();
    public List<Food> foodList = new List<Food>();


    public string UserName;
    private int branchId;
    
    protected override async void OnInitialized()
    {
        branchId = Int32.Parse(id);
        branchToShow = await BranchService.GetBranchByIdAsync(branchId);
    }
    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        
        UserName = user.Identity.Name;
        
        foodList = await BranchService.GetFood(branchId);
        
    }


    private void AddToBasket(string itemFoodName, double itemFoodPrice)
    {
        OrderFood = new OrderFood();
        OrderFood.foodName = itemFoodName;
        OrderFood.foodPrice = itemFoodPrice;
        
        Orders newUserOrder = new Orders();
        newUserOrder.username = UserName;
        newUserOrder.price = itemFoodPrice;

        OrderFood.orders = newUserOrder;

        OrdersService.AddOrderFoodAsync(OrderFood);

        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdersService OrdersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBranchService BranchService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
