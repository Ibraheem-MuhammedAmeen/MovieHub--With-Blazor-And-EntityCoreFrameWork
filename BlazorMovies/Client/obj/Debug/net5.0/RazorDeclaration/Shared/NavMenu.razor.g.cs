// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository

#nullable disable
    ;
#nullable restore
#line 15 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 16 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
