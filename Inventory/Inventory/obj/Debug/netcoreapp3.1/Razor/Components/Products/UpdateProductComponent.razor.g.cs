#pragma checksum "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5097ed935e421ad86d4308593c0aa21ea5a601db"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Products
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
#line 1 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                     oProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<label>Producto</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                         oProduct.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductName = __value, oProduct.ProductName))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<label>Descripción</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                             oProduct.ProductDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.ProductDescription = __value, oProduct.ProductDescription))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.ProductDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label>Categoría</label>\r\n            ");
                __Blazor.Inventory.Components.Products.UpdateProductComponent.TypeInference.CreateInputSelect_0(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 16 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                           oProduct.CategoryId

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.CategoryId = __value, oProduct.CategoryId)), 34, () => oProduct.CategoryId, 35, (__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n");
#nullable restore
#line 17 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                 foreach (var category in categories)
	            {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(37, "\t\t            ");
                    __builder3.OpenElement(38, "option");
                    __builder3.AddAttribute(39, "value", 
#nullable restore
#line 19 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                    category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(40, 
#nullable restore
#line 19 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                           category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(41, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n");
#nullable restore
#line 20 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
	            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(43, "            ");
                }
                );
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "value", "Actualizar Producto");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                                   UpdateProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\BamopetLP\Desktop\Proyectos\csharp\1. Blazor App Fundamental Platzi\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
       
    [Parameter]
    public string IdProduct { get; set; }

    ProductEntity oProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
        oProduct = B_Product.ProductByid(IdProduct);
    }

    private void UpdateProduct()
    {
        B_Product.UpdateProduct(oProduct);
        NavManager.NavigateTo("product/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.Inventory.Components.Products.UpdateProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
