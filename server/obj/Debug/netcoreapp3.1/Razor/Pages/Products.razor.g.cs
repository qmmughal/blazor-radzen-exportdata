#pragma checksum "F:\Logics\ExportOperations\server\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6dcd1cc025681e67174cc8d719bd5fe96e5e0f8"
// <auto-generated/>
#pragma warning disable 1591
namespace ExportOperations.Pages
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
#line 6 "F:\Logics\ExportOperations\server\Pages\Products.razor"
using Radzen;

#line default
#line hidden
#line 7 "F:\Logics\ExportOperations\server\Pages\Products.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "F:\Logics\ExportOperations\server\Pages\Products.razor"
using ExportOperations.Models.SampleDb;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : ExportOperations.Pages.ProductsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Products");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-bottom: 10px; margin-left: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#line 17 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 25 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await Load();}

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ExportOperations.Models.SampleDb.Product>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(41, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ExportOperations.Models.SampleDb.Product>>(
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                     getProductsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(42, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                                    FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(43, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportOperations.Models.SampleDb.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportOperations.Models.SampleDb.Product>(this, 
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                                                                                                                      Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(44, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ExportOperations.Models.SampleDb.Product>>(45);
                    __builder3.AddAttribute(46, "Property", "Id");
                    __builder3.AddAttribute(47, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ExportOperations.Models.SampleDb.Product>>(49);
                    __builder3.AddAttribute(50, "Property", "ProductName");
                    __builder3.AddAttribute(51, "Title", "Product Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ExportOperations.Models.SampleDb.Product>>(53);
                    __builder3.AddAttribute(54, "FormatString", "{0:C}");
                    __builder3.AddAttribute(55, "Property", "ProductPrice");
                    __builder3.AddAttribute(56, "Title", "Product Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ExportOperations.Models.SampleDb.Product>>(58);
                    __builder3.AddAttribute(59, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 35 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                           false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "Property", "ProductPicture");
                    __builder3.AddAttribute(61, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 35 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                                      false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "Title", "Product Picture");
                    __builder3.AddAttribute(63, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ExportOperations.Models.SampleDb.Product>)((data) => (__builder4) => {
                        __builder4.OpenElement(64, "img");
                        __builder4.AddAttribute(65, "src", 
#line 37 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                         data.ProductPicture

#line default
#line hidden
                        );
                        __builder4.AddAttribute(66, "width", "50%");
                        __builder4.AddAttribute(67, "height", "50%");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ExportOperations.Models.SampleDb.Product>>(69);
                    __builder3.AddAttribute(70, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 40 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                           false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(71, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 40 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                            false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(72, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 40 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                              TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(73, "Width", "70px");
                    __builder3.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ExportOperations.Models.SampleDb.Product>)((exportOperationsModelsSampleDbProduct) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(75);
                        __builder4.AddAttribute(76, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 42 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(77, "Icon", "close");
                        __builder4.AddAttribute(78, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 42 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(79, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, exportOperationsModelsSampleDbProduct)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(80, "onclick", 
#line 42 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                                                                                                                                                                                                                     true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(81, (__value) => {
#line 27 "F:\Logics\ExportOperations\server\Pages\Products.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ExportOperations.Models.SampleDb.Product>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
