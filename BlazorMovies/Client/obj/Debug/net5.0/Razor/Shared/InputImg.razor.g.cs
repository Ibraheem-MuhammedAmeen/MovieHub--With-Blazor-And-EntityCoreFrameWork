#pragma checksum "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fba5a0b574638619b57fee9b3dc42011eebea72ea7f56372eb9b8e1f678f7137"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class InputImg : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputFile>(5);
            __builder.AddAttribute(6, "accept", (object)(".jpg,.jpeg,.png"));
            __builder.AddAttribute(7, "OnChange", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
                                                      OnChange

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "div");
#nullable restore
#line 9 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
     if (imageBase64 != null)
    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin:10px");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 13 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
                                                   imageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 17 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
     if (ImageURL != null)
    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(16, "div");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "margin:10px");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 21 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
                           ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Shared\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    [Parameter] public string ImageURL { get; set; }
    private string imageBase64;

    async Task OnChange(InputFileChangeEventArgs e)
    {
        var imagesFiles = e.GetMultipleFiles();

        foreach (var imageFile in imagesFiles)
        {
            var buffer = new byte[imageFile.Size];
            await imageFile.OpenReadStream().ReadAsync(buffer);
            imageBase64 = Convert.ToBase64String(buffer);
            await OnSelectedImage.InvokeAsync(imageBase64);
            ImageURL = null;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591