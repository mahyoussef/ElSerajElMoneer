#pragma checksum "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3cdbe54bbaae92cf6f0931503beb7c495c777e"
// <auto-generated/>
#pragma warning disable 1591
namespace ElSerajElMoneer.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using ElSerajElMoneer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/_Imports.razor"
using ElSerajElMoneer.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddAttribute(1, "b-r4g082flam");
            __builder.AddMarkupContent(2, "@import url(\'https://fonts.googleapis.com/css2?family=Noto+Kufi+Arabic:wght@700&display=swap\');\n\n    body {\n        font-family: \'Noto Kufi Arabic\', sans-serif;\n    }\n\n    .sidebar[b-z5li2q9z35] {\n        background-image: linear-gradient( 180deg, ");
#nullable restore
#line 9 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
__builder.AddContent(3, backgroundColor);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, " 0%, #171418 70%);\n    }\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\" b-r4g082flam>\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row mx-auto navbar navbar-dark");
            __builder.AddAttribute(8, "b-r4g082flam");
            __builder.AddMarkupContent(9, "<a class=\"navbar-brand mx-auto\" href style=\"font-size:24px\" b-r4g082flam>\n        السراج المنير  ﷺ\n    </a>\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "navbar-toggler");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-r4g082flam");
            __builder.AddMarkupContent(14, "<span class=\"navbar-toggler-icon\" b-r4g082flam></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 23 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-r4g082flam");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "nav flex-column");
            __builder.AddAttribute(22, "b-r4g082flam");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item px-3");
            __builder.AddAttribute(25, "b-r4g082flam");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link text-center");
            __builder.AddAttribute(28, "href", "/");
            __builder.AddAttribute(29, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
                                                                                              () => ChangeNavMenuColor("home")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "<span class=\"oi oi-home\" dir=\"rtl\" lang=\"ar\" aria-hidden=\"true\" b-r4g082flam></span> الرئيسية\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item px-3");
            __builder.AddAttribute(36, "b-r4g082flam");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "/taghredat");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
                                                                    () => ChangeNavMenuColor("taghredat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class dir=\"rtl\" lang=\"ar\" aria-hidden=\"true\" b-r4g082flam><i class=\"fa fa-twitter px-2\" style=\"font-size:20px;\" b-r4g082flam></i></span> تغريدات في السيرة\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item px-3");
            __builder.AddAttribute(46, "b-r4g082flam");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "href", "counter");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-r4g082flam></span> Counter\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "nav-item px-3");
            __builder.AddAttribute(55, "b-r4g082flam");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
            __builder.AddAttribute(57, "class", "nav-link");
            __builder.AddAttribute(58, "href", "fetchdata");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-r4g082flam></span> Fetch data\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private static Dictionary<string, string> navMenuColors = new Dictionary<string, string>()
    {
        { "taghredat", "#2cb4dd" },
        { "home", "#662f34"}
    };
    string backgroundColor = navMenuColors["home"];
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private void ChangeNavMenuColor(string pageName)
    {
        backgroundColor = navMenuColors[pageName];
        Console.WriteLine(pageName);
        Console.WriteLine(backgroundColor);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
