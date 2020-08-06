#pragma checksum "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0abc04a2d479371e84d74f08b276ba8fc94ccf1b"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema.Ecommerce.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Sistema.Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Sistema.Ecommerce.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Sistema.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Sistema.Shared.Services.Usuario.Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MasComprados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "clean-block clean-info dark");
            __builder.AddAttribute(2, "style", "padding-top: 10px;");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "section");
            __builder.AddAttribute(8, "class", "clean-block about-us");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.AddMarkupContent(13, "<div class=\"block-heading\">\n                    <h2 class=\"text-info\">Tendencias</h2>\n                    <p></p>\n                </div>\n");
#nullable restore
#line 9 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                 if (Productos != null)
                {
                    for (int i = 0; i < 2; i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row justify-content-center pt-2 pb-2");
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 14 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                             for (int j = ((i == 0) ? 0 : 3); j < ((i == 0) ? 3 : 6); j++)
                            {
                                if (j < Productos.Count)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-6 col-lg-4");
            __builder.AddMarkupContent(21, "\n                                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card clean-card text-center");
            __builder.AddMarkupContent(24, "\n                                            ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "class", "card-img-top w-100 d-block");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 20 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                                                                                          PoductoHelper.GetFotoUrl(Productos[j].Fotos.FirstOrDefault())

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "style", "height: 250px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                                            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-body info");
            __builder.AddMarkupContent(32, "\n                                                ");
            __builder.OpenElement(33, "h4");
            __builder.AddAttribute(34, "class", "card-title");
            __builder.AddContent(35, 
#nullable restore
#line 22 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                                                                        Productos[j].Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                                                ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "card-text");
            __builder.AddContent(39, 
#nullable restore
#line 23 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                                                                      PoductoHelper.GetDescripcion(Productos[j].Descripcion)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "producto/" + (
#nullable restore
#line 23 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                                                                                                                                                   Productos[j].Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddContent(44, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 27 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 30 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                    ");
            __builder.OpenComponent<Sistema.Ecommerce.Components.Loading>(52);
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n");
#nullable restore
#line 35 "/home/alexander/Documents/P3_Experience/Sistema_Ventas/Sistema.Ecommerce/Components/MasComprados.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
