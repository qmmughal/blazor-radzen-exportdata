#pragma checksum "F:\Logics\ExportOperations\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cabd7291a08789b05a9d3bd585c459e0f3621513"
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
#line 3 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
using ExportOperations.Models.SampleDb;

#line default
#line hidden
    public partial class MainLayout : ExportOperations.Layouts.MainLayoutComponent
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
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row justify-content-start align-items-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-6 d-flex align-items-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(14);
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 15 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                __builder2.AddAttribute(18, "Text", "ExportOperations");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      <div class=\"col-6 text-right\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(21);
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(23);
                __builder2.AddAttribute(24, "Name", "main");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, 
#line 28 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(27, (__value) => {
#line 25 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(29);
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(31);
                __builder2.AddAttribute(32, "style", "height: 100%");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(34);
                    __builder3.AddAttribute(35, "Text", "Products");
                    __builder3.AddAttribute(36, "Path", "products");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(37, (__value) => {
#line 32 "F:\Logics\ExportOperations\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(39);
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                __builder2.AddAttribute(42, "Text", "ExportOperations, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591