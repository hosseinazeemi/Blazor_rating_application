#pragma checksum "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e08d9e89e978e4dcf2dd5f46e562bf6488dbab78"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalBlazorIndivisualUser.Client.Pages.PostComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using FinalBlazorIndivisualUser.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using FinalBlazorIndivisualUser.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using FinalBlazorIndivisualUser.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using FinalBlazorIndivisualUser.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/post/edit/{Id:int}")]
    public partial class EditPost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container shadow mt-4 p-5");
#nullable restore
#line 8 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
     if (CurrentUserId != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
         if (ShowMessage)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "class", "text-center alert alert-info");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                         post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                              EditThisPost

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label>Category : </label>\r\n                ");
                __builder2.OpenElement(16, "select");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                               post.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.CategoryId = __value, post.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 21 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                     if (categories != null && categories.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "option");
                __builder2.AddAttribute(21, "value", "0");
                __builder2.AddContent(22, "Select Category");
                __builder2.CloseElement();
#nullable restore
#line 24 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                        foreach (Category item in categories)
                        {
                            if (post.CategoryId == item.Id)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "option");
                __builder2.AddAttribute(24, "value", 
#nullable restore
#line 28 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(25, "selected");
                __builder2.AddContent(26, 
#nullable restore
#line 28 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                                   item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 29 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "value", 
#nullable restore
#line 32 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(29, 
#nullable restore
#line 32 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                          item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                            }

                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value", "0");
                __builder2.AddContent(32, "Category Not Selected");
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label>Title :</label>\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                                     post.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Title = __value, post.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Image URL :</label>\r\n                ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "text");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                                     post.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Image = __value, post.Image));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
#nullable restore
#line 50 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                 if (post.Image != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "img");
                __builder2.AddAttribute(52, "src", 
#nullable restore
#line 52 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                               post.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(53, "width", "150");
                __builder2.AddAttribute(54, "class", "rounded mt-2");
                __builder2.CloseElement();
#nullable restore
#line 53 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "<label>Description :</label>\r\n                ");
                __builder2.OpenElement(59, "textarea");
                __builder2.AddAttribute(60, "cols", "30");
                __builder2.AddAttribute(61, "rows", "3");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
                                                    post.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Description = __value, post.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.AddMarkupContent(66, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-success mt-3\">\r\n                    Submit\r\n                </button></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 66 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
    }else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "<p>You dont have permission</p>");
#nullable restore
#line 69 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\EditPost.razor"
       
    Post post;

    [Parameter]
    public int Id { get; set; }
    public string Message = null;
    public bool ShowMessage = false;
    List<Category> categories;
    public string CurrentUserId = null;
    private Task<AuthenticationState> authState;
    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        CurrentUserId = authState.User.Claims.Where(p => p.Type == "CurrentUserId").Select(c => c.Value).FirstOrDefault();

        post = new Post();

        var myPostResult = await postRepository.GetPostWithId(Id);
        if (myPostResult.Status)
        {
            if (myPostResult.Response != null)
            {
                if (myPostResult.Response.UserId == CurrentUserId)
                {
                    post = myPostResult.Response;
                }else
                {
                    CurrentUserId = null;
                }

            }
        }
        else
        {
            ShowMessage = true;
            Message = "There is no such a post";
        }

        var result = await categoryRepository.GetCategories();
        if (result.Status)
        {
            if (result.Response != null && result.Response.Count > 0)
            {
                categories = result.Response;
            }
            else
            {
                categories = new List<Category>();
            }
        }
        else
        {
            categories = new List<Category>();
        }


    }

    private async Task EditThisPost()
    {
        if (post.CategoryId == 0)
        {
            ShowMessage = true;
            Message = "Category Field is required !";
        }
        else
        {
            var result = await postRepository.UpdatePost(post);
            ShowMessage = true;
            if (result.Status)
            {
                if (result.Response)
                {
                    Message = "Post has been edited successfuly";
                }
                else
                {
                    Message = "Failed to edit the post";
                }
            }
            else
            {
                Message = "Something went wrong ,try again";
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryRepository categoryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostRepository postRepository { get; set; }
    }
}
#pragma warning restore 1591
