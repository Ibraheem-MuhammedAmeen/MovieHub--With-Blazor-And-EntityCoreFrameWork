#pragma checksum "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d3f02e63e92bdbb843ae45bb98913309689e0925a66e78cbefc15b94ca33fa20"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Auth
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

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
 using BlazorMovies.Client.Auth

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
      "/register"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Register : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\n\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 11 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                 userInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                                          CreateUser

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label>Email:</label>\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", (object)("form-control"));
                __builder2.AddAttribute(13, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                                                          userInfo.Email

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.Email = __value, userInfo.Email)))));
                __builder2.AddAttribute(15, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.Email)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n            ");
                global::__Blazor.BlazorMovies.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 18 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                                      () => userInfo.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label>Password:</label>\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenComponent<global::BlazorMovies.Client.Shared.InputPassword>(24);
                __builder2.AddAttribute(25, "class", (object)("form-control"));
                __builder2.AddAttribute(26, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 25 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                                                              userInfo.Password

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.Password = __value, userInfo.Password)))));
                __builder2.AddAttribute(28, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.Password)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n            ");
                global::__Blazor.BlazorMovies.Client.Pages.Auth.Register.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 26 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                                      () => userInfo.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n\n    ");
                __builder2.AddMarkupContent(33, "<button type=\"submit\" class=\"btn btn-primary\">Register</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
       
    private UserInfo userInfo = new UserInfo();

    private async Task CreateUser()
    {
        var userToken = await accountsRepository.Register(userInfo);
        await loginService.Login(userToken);
        navigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
        ILoginService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                      loginService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                          navigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
        IAccountsRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\Abdulmalik\Downloads\BlazorMovies-master (1)\BlazorMovies-master\ASP.NET Core 5\Module 8 - Deployment\Blazor Movies\BlazorMovies\Client\Pages\Auth\Register.razor"
                            accountsRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Auth.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
