#pragma checksum "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e376f5d4c1c7aa24aed6781692b20de57804af4a9b402098d098be71dde2c4ee"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Genres
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
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable

    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
      "/genres"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class IndexGenres : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index Genres</h3>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"genre/create\">New Genre</a></div>\n\n");
            global::__Blazor.BlazorMovies.Client.Pages.Genres.IndexGenres.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 11 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                   Genres

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-striped");
                __builder2.AddMarkupContent(7, "<thead><tr><th></th>\n                    <th>Name</th></tr></thead>\n            ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 21 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                 foreach (var item in Genres)
                {

#line default
#line hidden
#nullable disable

                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.OpenElement(11, "a");
                __builder2.AddAttribute(12, "class", "btn btn-success");
                __builder2.AddAttribute(13, "href", "/genre/edit/" + (
#nullable restore
#line 25 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                                                                          item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(14, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n                            ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "class", "btn btn-danger");
                __builder2.AddAttribute(18, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                                                                       () => DeleteGenres(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n                        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 28 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                }

#line default
#line hidden
#nullable disable

                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
       

    List<Genre> Genres;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Genres = await genreRepository.GetGenres();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task DeleteGenres(int Id)
    {
        await genreRepository.DeleteGenre(Id);
        Genres = await genreRepository.GetGenres();
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
        IGenreRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Genres\IndexGenres.razor"
                         genreRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Genres.IndexGenres
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", (object)__arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", (object)__arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591