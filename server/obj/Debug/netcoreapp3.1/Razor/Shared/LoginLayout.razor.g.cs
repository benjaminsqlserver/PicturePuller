#pragma checksum "C:\PicturePuller\server\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78eade8a5fe11e21461f21d3bf3964b30253f7ec"
// <auto-generated/>
#pragma warning disable 1591
namespace PicturePuller.Shared
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
#line 3 "C:\PicturePuller\server\Shared\LoginLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\PicturePuller\server\Shared\LoginLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\PicturePuller\server\Shared\LoginLayout.razor"
using PicturePuller.Models.ConData;

#line default
#line hidden
    public partial class LoginLayout : PicturePuller.Layouts.LoginLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(4);
            __builder.AddAttribute(5, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 9 "C:\PicturePuller\server\Shared\LoginLayout.razor"
                                    true

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row justify-content-center");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "justify-content-center col-xl-5 col-md-7");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(14);
                __builder2.AddAttribute(15, "style", "margin-top: 8rem");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenContentContainer>(18);
                    __builder3.AddAttribute(19, "Name", "main");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(21, "\n            ");
                        __builder4.AddContent(22, 
#line 16 "C:\PicturePuller\server\Shared\LoginLayout.razor"
             Body

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(23, "\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(28, (__value) => {
#line 9 "C:\PicturePuller\server\Shared\LoginLayout.razor"
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
