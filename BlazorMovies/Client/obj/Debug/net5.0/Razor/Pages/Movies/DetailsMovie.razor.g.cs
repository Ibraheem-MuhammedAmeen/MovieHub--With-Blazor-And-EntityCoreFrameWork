#pragma checksum "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d67099915545eedb6832672f31c4ae8bab574c63db4171a2f858d53175a06a50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
      "/movie/{MovieId:int}"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 2 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
      "/movie/{MovieId:int}/{MovieName}"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class DetailsMovie : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable

            __builder.AddContent(0, "Loading...");
#nullable restore
#line 9 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                           
}
else
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 13 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
         model.Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 13 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                             model.Movie.ReleaseDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
    for (int i = 0; i < model.Genres.Count; i++)
    {
        if (i < model.Genres.Count - 1)
        {
            

#line default
#line hidden
#nullable disable

            __builder.AddContent(6, 
#nullable restore
#line 18 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
             linkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ", ");
#nullable restore
#line 18 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                      
        }
        else
        {
            

#line default
#line hidden
#nullable disable

            __builder.AddContent(8, 
#nullable restore
#line 22 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
             linkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                       
        }
    }
    

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 25 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                            model.Movie.ReleaseDate.Value.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " | Average: ");
            __builder.AddContent(13, 
#nullable restore
#line 26 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                               model.AverageVote.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "/5 | Your vote: \n    ");
            __builder.OpenComponent<global::BlazorMovies.Client.Shared.Rating>(15);
            __builder.AddAttribute(16, "MaximumRating", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 27 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                           5

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "SelectedRating", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 27 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                              model.UserVote

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "OnVote", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 27 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                      OnVote

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "display: flex");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 30 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                           model.Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "style", "width: 225px; height: 315px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "iframe");
            __builder.AddAttribute(28, "width", "560");
            __builder.AddAttribute(29, "height", "315");
            __builder.AddAttribute(30, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 31 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                             model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "frameborder", "0");
            __builder.AddAttribute(32, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(33, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(37, "<h3>Summary</h3>\n        ");
            __builder.OpenElement(38, "div");
            __builder.OpenComponent<global::BlazorMovies.Client.Shared.RenderMarkdown>(39);
            __builder.AddAttribute(40, "MarkdownContent", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                              model.Movie.Summary

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(44, "<h3>Actors</h3>\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "display: flex; flex-direction: column");
#nullable restore
#line 42 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
             foreach (var actor in model.Actors)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "margin-bottom: 2px;");
            __builder.OpenElement(49, "img");
            __builder.AddAttribute(50, "style", "width: 50px;");
            __builder.AddAttribute(51, "src", 
#nullable restore
#line 45 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                    actor.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                    ");
            __builder.OpenElement(53, "span");
            __builder.AddAttribute(54, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "href", "/person/" + (
#nullable restore
#line 46 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                       actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 46 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                 actor.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, 
#nullable restore
#line 46 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                                                actor.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                    ");
            __builder.AddMarkupContent(59, "<span style=\"display:inline-block; width: 45px;\">...</span>\n                    ");
            __builder.OpenElement(60, "span");
            __builder.AddContent(61, 
#nullable restore
#line 48 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                           actor.Character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    [Parameter] public string MovieName { get; set; }
    private RenderFragment<Genre> linkGenre = (genre) =>

#line default
#line hidden
#nullable disable

        (__builder2) => {
            __builder2.OpenElement(62, "a");
            __builder2.AddAttribute(63, "href", "movies/search?genreId=" + (
#nullable restore
#line 58 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                         genre.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(64, 
#nullable restore
#line 58 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                      genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 58 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                                     ;
    DetailsMovieDTO model;

    protected async override Task OnInitializedAsync()
    {
        model = await moviesRepository.GetDetailsMovieDTO(MovieId);
    }

    private async Task OnVote(int selectedRate)
    {
        model.UserVote = selectedRate;
        var movieRating = new MovieRating() { Rate = selectedRate, MovieId = MovieId };
        await ratingRepository.Vote(movieRating);
        await displayMessage.DisplaySuccessMessage("Your vote have been received!");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
        IDisplayMessage

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                        displayMessage

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
        IRatingRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                          ratingRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
        IMoviesRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                          moviesRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
