#pragma checksum "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1af87271c1364385f9499e1e824d3db38c8225"
// <auto-generated/>
#pragma warning disable 1591
namespace ElSerajElMoneer.Client.Pages
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
#nullable restore
#line 2 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
using ElSerajElMoneer.Data.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taghredat/{id}")]
    public partial class Taghreda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    body {\n        font-family: \'Noto Kufi Arabic\', sans-serif;\n        background-color: #eee;\n    }\n\n    .main > div[b-z5li2q9z35] {\n        padding-left: 0rem !important;\n        padding-right: 0rem !important;\n    }\n\n    .masthead {\n        padding: 0rem 0 0rem;\n        position: relative;\n        background-color: #2cb4dd;\n        background-image: url(https://startbootstrap.com/assets/img/overlay.svg), linear-gradient(45deg, #2cb4dd 0%, #2cb4dd 100%);\n        background-size: cover;\n        z-index: 0\n    }\n\n        .masthead svg.wave {\n            position: absolute;\n            bottom: -1px;\n            left: 0\n        }\n\n        .masthead h3, h4, h5 {\n            color: #fff;\n            line-height: 1.6;\n        }\n\n        .masthead h1 {\n            color: #fff;\n            font-weight: 700;\n            font-size: 2rem;\n            line-height: 1.1;\n            z-index: 1\n        }\n\n        .masthead h5 {\n            color: rgba(255, 255, 255, .6);\n            font-weight: 600;\n            z-index: 1;\n            font-size: 1.2rem\n        }\n\n        .masthead a {\n            color: rgba(255, 255, 255, .8);\n            text-decoration: underline;\n            z-index: 1\n        }\n\n            .masthead a:hover {\n                color: #fff\n            }\n\n            .masthead a:active {\n                text-decoration: none\n            }\n\n    @media(min-width:992px) {\n        .masthead h1 {\n            font-size: 3rem\n        }\n\n        .masthead h2 {\n            font-size: 1.5rem\n        }\n    }\n\n    .masthead .masthead-cards {\n        position: relative;\n        z-index: 1\n    }\n\n        .masthead .masthead-cards .shape {\n            position: absolute;\n            height: 100%;\n            width: 100%;\n            background-color: rgba(255, 255, 255, .3);\n            top: 0;\n            left: 0;\n            z-index: -1;\n            border-radius: 30% 70% 70% 30%/30% 30% 70% 70%\n        }\n\n        .masthead .masthead-cards .card {\n            opacity: 1;\n            font-size: .8rem;\n            text-transform: uppercase;\n            font-weight: 800;\n            letter-spacing: .05rem;\n            color: #212529;\n            transition: .15s all\n        }\n\n            .masthead .masthead-cards .card:hover {\n                margin-top: -.25rem;\n                margin-bottom: .25rem\n            }\n\n            .masthead .masthead-cards .card:active {\n                margin-top: inherit;\n                margin-bottom: inherit\n            }\n\n            .masthead .masthead-cards .card.border-bottom-blue:hover {\n                color: #2092ed\n            }\n\n            .masthead .masthead-cards .card.border-bottom-green:hover {\n                color: #28a745\n            }\n\n            .masthead .masthead-cards .card.border-bottom-red:hover {\n                color: #dd3d31\n            }\n\n            .masthead .masthead-cards .card.border-bottom-yellow:hover {\n                color: #ffc107\n            }\n\n    .masthead-page {\n        padding: 0rem 0 0rem\n    }\n\n    @media(min-width:992px) {\n        .masthead-page h1 {\n            font-size: 2.5rem\n        }\n    }\n\n    .border-bottom-yellow {\n        border-color: #ffc107 !important;\n    }\n\n    .border-bottom-red {\n        border-color: #dd3d31 !important;\n    }\n\n    .border-bottom-blue {\n        border-color: #2092ed !important;\n    }\n\n    .border-bottom-green {\n        border-color: #28a745 !important;\n    }\n\n    .border-bottom-blue, .border-bottom-green, .border-bottom-red, .border-bottom-yellow {\n        border-bottom: .4rem solid !important;\n    }\n\n    .shadow-lg {\n        box-shadow: 0 2rem 1.5rem -1.5rem rgba(33,37,41,.15),0 0 1.5rem .5rem rgba(33,37,41,.05) !important;\n    }\n\n    .border-0 {\n        border: 0 !important;\n    }\n\n    :root {\n        --surface-color: #fff;\n        --curve: 40;\n    }\n\n    * {\n        box-sizing: border-box;\n    }\n\n\n\n    .cards {\n        display: grid;\n        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));\n        gap: 2rem;\n        margin: 4rem 5vw;\n        padding: 0;\n        list-style-type: none;\n    }\n\n    .card {\n        position: relative;\n        display: block;\n        height: 100%;\n        border-radius: calc(var(--curve) * 1px);\n        overflow: hidden;\n        text-decoration: none;\n    }\n\n    .card__image {\n        width: 100%;\n        height: auto;\n    }\n\n    .card__overlay {\n        position: absolute;\n        bottom: 0;\n        left: 0;\n        right: 0;\n        z-index: 1;\n        border-radius: calc(var(--curve) * 1px);\n        background-color: var(--surface-color);\n        transform: translateY(100%);\n        transition: .2s ease-in-out;\n    }\n\n    .card:hover .card__overlay {\n        transform: translateY(0);\n    }\n\n    .card__header {\n        position: relative;\n        display: flex;\n        align-items: center;\n        gap: 2em;\n        padding: 1em;\n        border-radius: calc(var(--curve) * 1px) 0 0 0;\n        background-color: var(--surface-color);\n        transform: translateY(-100%);\n        transition: .2s ease-in-out;\n    }\n\n    .card__arc {\n        width: 80px;\n        height: 80px;\n        position: absolute;\n        bottom: 100%;\n        right: 0;\n        z-index: 1;\n    }\n\n        .card__arc path {\n            fill: var(--surface-color);\n            d: path(\"M 40 80 c 22 0 40 -22 40 -40 v 40 Z\");\n        }\n\n    .card:hover .card__header {\n        transform: translateY(0);\n    }\n\n    .card__thumb {\n        flex-shrink: 0;\n        width: 50px;\n        height: 50px;\n        border-radius: 50%;\n    }\n\n    .card__title {\n        font-size: 1em;\n        margin: 0 0 .3em;\n        color: #6A515E;\n    }\n\n    .card__tagline {\n        display: block;\n        margin: 1em 0;\n        font-family: \"MockFlowFont\";\n        font-size: .8em;\n        color: #D7BDCA;\n    }\n\n    .card__status {\n        font-size: .8em;\n        color: #D7BDCA;\n    }\n\n    .card__description {\n        padding: 0 2em 2em;\n        margin: 0;\n        color: #D7BDCA;\n        font-family: \"MockFlowFont\";\n        display: -webkit-box;\n        -webkit-box-orient: vertical;\n        -webkit-line-clamp: 3;\n        overflow: hidden;\n    }\n\n\n    .buttonDownload {\n        display: inline-block;\n        position: relative;\n        padding: 10px 25px;\n        background-color: #2bb4dd;\n        color: white;\n        text-decoration: none;\n        font-size: 0.9em;\n        text-align: center;\n        text-indent: 15px;\n        border-top-right-radius: 15px;\n    }\n\n        .buttonDownload:hover {\n            background-color: #0e485a;\n            color: white;\n        }\n\n    .buttonWatch {\n        display: inline-block;\n        position: relative;\n        padding: 10px 25px;\n        background-color: #c21f37;\n        color: white;\n        text-decoration: none;\n        font-size: 0.9em;\n        text-align: center;\n        text-indent: 15px;\n        border-top-left-radius: 15px;\n    }\n\n        .buttonWatch:hover {\n            background-color: #6e111f;\n            color: white;\n        }\n\n        .buttonDownload:before, .buttonDownload:after, .buttonWatch:before, .buttonWatch:after {\n            content: \' \';\n            display: block;\n            position: absolute;\n            left: 15px;\n            top: 52%;\n        }\n\n    /* Download box shape  */\n    .buttonDownload:before, buttonWatch:before {\n        width: 10px;\n        height: 2px;\n        border-style: solid;\n        border-width: 0 2px 2px;\n    }\n\n    /* Download arrow shape */\n    .buttonDownload:after, buttonWatch:after {\n        width: 0;\n        height: 0;\n        margin-left: 3px;\n        margin-top: -7px;\n        border-style: solid;\n        border-width: 4px 4px 0 4px;\n        border-color: transparent;\n        border-top-color: inherit;\n        animation: downloadArrow 2s linear infinite;\n        animation-play-state: paused;\n    }\n\n    .buttonDownload:hover:before, .buttonWatch:hover:before {\n        border-color: #4CC713;\n    }\n\n    .buttonDownload:hover:after, .buttonWatch:hover:after {\n        border-top-color: #4CC713;\n        animation-play-state: running;\n    }\n\n    /* keyframes for the download icon anim */\n    @keyframes downloadArrow {\n        /* 0% and 0.001% keyframes used as a hackish way of having the button frozen on a nice looking frame by default */\n        0% {\n            margin-top: -7px;\n            opacity: 1;\n        }\n\n        0.001% {\n            margin-top: -15px;\n            opacity: 0;\n        }\n\n        50% {\n            opacity: 1;\n        }\n\n        100% {\n            margin-top: 0;\n            opacity: 0;\n        }\n    }\n</style>\n\n<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">\n<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>\n<link href=\"https://fonts.googleapis.com/css2?family=Noto+Kufi+Arabic:wght@700&display=swap\" rel=\"stylesheet\">\n<link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\n\n");
            __builder.AddMarkupContent(1, "<header class=\"masthead mx-0 pt-0\"><div class=\"container\"><div class=\"row align-items-center pb-5\"><div class=\"col-lg-7 py-5\"><h1 class=\"mb-4 text-center\" dir=\"rtl\" lang=\"ar\">\n                    السّيِرَةُ النَّبَوِيَّةٌ في تَغْرِيدَات\n                    <br></h1>\n                <h4 class=\"mb-4 text-center\" dir=\"rtl\" lang=\"ar\">\n                    تأليف : موسى بن راشد العازمي\n                    <br>\n                    صوت : فيصل بن جذيان العتيبي\n                    <br>\n                    برعاية : وقف سارة بنت راشد بن غنيم الحقباني\n\n                </h4>\n                <h1 class=\"m-0 text-center\">\n                    Biography of the Prophet in Tweets\n                    <br></h1>\n                <h5 class=\"mb-4 text-center\">\n                    Author : Mousa Ibn Rashed El-Azmy\n                    <br>\n                    Voice : Faisal Ibn Gazyan El-Otyeby\n                    <br>\n                    Subervision : Waqf Sarah Bnt Rashed Ibn Ghoniem Al-Haqbany\n                </h5></div>\n            <div class=\"col-lg-5 pb-5 pt-3 masthead-cards\"><img src=\"twitter-bird-icon-9-removebg-preview.png\" height=\"400\" width=\"400\">\n                <div class=\"shape\"></div></div></div></div>\n    <svg style=\"pointer-events: none\" class=\"wave\" width=\"100%\" height=\"50px\" preserveAspectRatio=\"none\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" viewBox=\"0 0 1920 75\"><defs><style>\n                .a {\n                    fill: none;\n                }\n\n                .b {\n                    clip-path: url(#a);\n                }\n\n                .c,\n                .d {\n                    fill: #eee;\n                }\n\n                .d {\n                    opacity: 0.5;\n                    isolation: isolate;\n                }\n            </style>\n            <clipPath id=\"a\"><rect class=\"a\" width=\"1920\" height=\"75\"></rect></clipPath></defs>\n        <title>wave</title>\n        <g class=\"b\"><path class=\"c\" d=\"M1963,327H-105V65A2647.49,2647.49,0,0,1,431,19c217.7,3.5,239.6,30.8,470,36,297.3,6.7,367.5-36.2,642-28a2511.41,2511.41,0,0,1,420,48\"></path></g>\n        <g class=\"b\"><path class=\"d\" d=\"M-127,404H1963V44c-140.1-28-343.3-46.7-566,22-75.5,23.3-118.5,45.9-162,64-48.6,20.2-404.7,128-784,0C355.2,97.7,341.6,78.3,235,50,86.6,10.6-41.8,6.9-127,10\"></path></g>\n        <g class=\"b\"><path class=\"d\" d=\"M1979,462-155,446V106C251.8,20.2,576.6,15.9,805,30c167.4,10.3,322.3,32.9,680,56,207,13.4,378,20.3,494,24\"></path></g>\n        <g class=\"b\"><path class=\"d\" d=\"M1998,484H-243V100c445.8,26.8,794.2-4.1,1035-39,141-20.4,231.1-40.1,378-45,349.6-11.6,636.7,73.8,828,150\"></path></g></svg></header>\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container pt-4 text-center");
            __builder.OpenElement(4, "h1");
#nullable restore
#line 467 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
__builder.AddContent(5, taghreda.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "iframe");
            __builder.AddAttribute(8, "width", "950");
            __builder.AddAttribute(9, "height", "534");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 468 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
                                           taghreda.WatchUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "title", "YouTube video player");
            __builder.AddAttribute(12, "frameborder", "0");
            __builder.AddAttribute(13, "style", "border-radius: 20px;");
            __builder.AddAttribute(14, "allow", "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(15, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 472 "/Users/mahyoussef/projects/ElSerajElMoneer/elserajelmoneer/Client/Pages/Taghreda.razor"
       
    [Parameter]
    public string Id { get; set; }
    private TaghredatElSeraResponse taghreda = new TaghredatElSeraResponse();
    private string watchUrl;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            taghreda = await Http.GetFromJsonAsync<TaghredatElSeraResponse>($"api/taghredatelsera/{Id}");
        }
        catch(AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
