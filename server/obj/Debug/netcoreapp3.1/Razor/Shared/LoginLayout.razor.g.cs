#pragma checksum "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29326212d0fbfd280b6a74f2c5ed29dafa2ab92c"
// <auto-generated/>
#pragma warning disable 1591
namespace ExportOperations.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\Logics\ExportOperations\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\Logics\ExportOperations\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\Logics\ExportOperations\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\Logics\ExportOperations\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\Logics\ExportOperations\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "F:\Logics\ExportOperations\server\_Imports.razor"
using ExportOperations.Shared;

#line default
#line hidden
#line 3 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
using ExportOperations.Models.SampleDb;

#line default
#line hidden
    public partial class LoginLayout : ExportOperations.Layouts.LoginLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(8);
            __builder.AddAttribute(9, "style", "margin-left: 0px");
            __builder.AddAttribute(10, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
                                                            true

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row justify-content-center");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "justify-content-center col-xl-5 col-md-7");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(16);
                __builder2.AddAttribute(17, "style", "margin-top: 8rem");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenContentContainer>(19);
                    __builder3.AddAttribute(20, "Name", "main");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(22, 
#line 18 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
             Body

#line default
#line hidden
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(23, (__value) => {
#line 11 "F:\Logics\ExportOperations\server\Shared\LoginLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
