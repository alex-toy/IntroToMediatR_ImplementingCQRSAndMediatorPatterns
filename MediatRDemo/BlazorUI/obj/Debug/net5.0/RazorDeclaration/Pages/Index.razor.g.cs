// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\_Imports.razor"
using DemoLibrary.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\Pages\Index.razor"
using DemoLibrary.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\Pages\Index.razor"
using DemoLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\Pages\Index.razor"
using DemoLibrary.Queries;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\source\Csharp\IntroToMediatR_ImplementingCQRSAndMediatorPatterns\MediatRDemo\BlazorUI\Pages\Index.razor"
       
    List<PersonModel> people = new();

    protected override async Task OnInitializedAsync()
    {
        people = await _mediatR.Send(new GetPersonsQuery());
        //return Task.FromResult(people);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MediatR.IMediator _mediatR { get; set; }
    }
}
#pragma warning restore 1591
