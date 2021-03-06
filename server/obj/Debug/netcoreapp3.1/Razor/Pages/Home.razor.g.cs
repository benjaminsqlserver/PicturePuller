#pragma checksum "C:\PicturePuller\server\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecf7ff387494ccbc81d6014f81e3e95d48c998e"
// <auto-generated/>
#pragma warning disable 1591
namespace PicturePuller.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\PicturePuller\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\PicturePuller\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\PicturePuller\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\PicturePuller\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\PicturePuller\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\PicturePuller\server\_Imports.razor"
using PicturePuller.Shared;

#line default
#line hidden
#line 6 "C:\PicturePuller\server\Pages\Home.razor"
using Radzen;

#line default
#line hidden
#line 7 "C:\PicturePuller\server\Pages\Home.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "C:\PicturePuller\server\Pages\Home.razor"
using PicturePuller.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : PicturePuller.Pages.HomeComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Search For Picture");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(14);
                __builder2.AddAttribute(15, "Text", "Enter Search Term For Image");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(17);
                __builder2.AddAttribute(18, "Name", "TxtSearchTerm");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 17 "C:\PicturePuller\server\Pages\Home.razor"
                                     searchTerm

#line default
#line hidden
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchTerm = __value, searchTerm))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => searchTerm));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                __builder2.AddAttribute(24, "Text", "Select Image Type");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n        ");
                __Blazor.PicturePuller.Pages.Home.TypeInference.CreateRadzenDropDown_0(__builder2, 26, 27, 
#line 21 "C:\PicturePuller\server\Pages\Home.razor"
                               getImageTypesResult

#line default
#line hidden
                , 28, "ImageTypeName", 29, "ImageTypeName", 30, "DdlImageType", 31, 
#line 21 "C:\PicturePuller\server\Pages\Home.razor"
                                                                                               imageType

#line default
#line hidden
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => imageType = __value, imageType)), 33, () => imageType);
                __builder2.AddMarkupContent(34, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.AddMarkupContent(39, "\n      ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-md-12");
                __builder2.AddAttribute(42, "style", "margin-left: 10px");
                __builder2.AddMarkupContent(43, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(44);
                __builder2.AddAttribute(45, "style", "margin-left: 250px");
                __builder2.AddAttribute(46, "Text", "Search Pixabay");
                __builder2.AddAttribute(47, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 27 "C:\PicturePuller\server\Pages\Home.razor"
                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(49);
                __builder2.AddAttribute(50, "style", "margin-left: 10px");
                __builder2.AddAttribute(51, "Text", "Reset ");
                __builder2.AddAttribute(52, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 29 "C:\PicturePuller\server\Pages\Home.razor"
                                                                      Button1Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "row");
                __builder2.AddMarkupContent(58, "\n      ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-12");
                __builder2.AddMarkupContent(61, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<PicturePuller.Models.Hit>>(62);
                __builder2.AddAttribute(63, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<PicturePuller.Models.Hit>>(
#line 35 "C:\PicturePuller\server\Pages\Home.razor"
                                        getImageResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(64, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<PicturePuller.Models.Hit>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<PicturePuller.Models.Hit>(this, 
#line 35 "C:\PicturePuller\server\Pages\Home.razor"
                                                                                                     Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(65, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<PicturePuller.Models.Hit>>(67);
                    __builder3.AddAttribute(68, "Property", "id");
                    __builder3.AddAttribute(69, "Title", "Image ID");
                    __builder3.AddAttribute(70, "Type", "integer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<PicturePuller.Models.Hit>>(72);
                    __builder3.AddAttribute(73, "Property", "previewURL");
                    __builder3.AddAttribute(74, "Title", "Preview Image");
                    __builder3.AddAttribute(75, "Type", "string");
                    __builder3.AddAttribute(76, "Template", (Microsoft.AspNetCore.Components.RenderFragment<PicturePuller.Models.Hit>)((picturePullerModelsHit) => (__builder4) => {
                        __builder4.AddMarkupContent(77, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(78);
                        __builder4.AddAttribute(79, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 41 "C:\PicturePuller\server\Pages\Home.razor"
                                     picturePullerModelsHit.previewURL

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(82, (__value) => {
#line 35 "C:\PicturePuller\server\Pages\Home.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<PicturePuller.Models.Hit>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.PicturePuller.Pages.Home
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Name", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
