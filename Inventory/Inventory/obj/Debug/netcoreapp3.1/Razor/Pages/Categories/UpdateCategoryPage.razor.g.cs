#pragma checksum "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Pages\Categories\UpdateCategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd03967849ba3914036da19ddb784764e8cf2fce"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/update/{CategoryId}")]
    public partial class UpdateCategoryPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Inventory.Components.Categories.UpdateCategoryComponent>(0);
            __builder.AddAttribute(1, "CategoryId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Pages\Categories\UpdateCategoryPage.razor"
                                      CategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Pages\Categories\UpdateCategoryPage.razor"
 
    [Parameter]
    public string CategoryId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        CategoryId = CategoryId;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
