#pragma checksum "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28fd0b6b82a60ea89f01ca4bc83e335f80be109"
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
    public partial class PostListNewDesign : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
 if (posts != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3 class=\"text-left p-3\">New Posts🌏</h3>");
#nullable restore
#line 9 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
     if (posts.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
#nullable restore
#line 12 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
             foreach (Post item in posts)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card mb-4 shadow-sm");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 17 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                   item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "w-100 border-bottom");
            __builder.AddAttribute(10, "style", " max-height: 250px; max-width = 250px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 19 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                                    item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                             if (item.Category != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddMarkupContent(19, "<strong>Category :</strong> ");
            __builder.AddContent(20, 
#nullable restore
#line 23 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                                                 item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddMarkupContent(23, "<strong>Likes :</strong> ");
            __builder.AddContent(24, 
#nullable restore
#line 27 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                                          item.Like

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "d-flex justify-content-between align-items-center");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "btn-group");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-sm btn-outline-secondary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                                                                                               () => ShowDetail(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Show");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "small");
            __builder.AddAttribute(37, "class", "text-muted");
            __builder.AddContent(38, 
#nullable restore
#line 33 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
                                                           item.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<p class=\"alert alert-info text-center\">The List is Empty</p>");
#nullable restore
#line 46 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
     

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FinalBlazorIndivisualUser.Client.Shared.Loading>(40);
            __builder.CloseComponent();
#nullable restore
#line 52 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\PostListNewDesign.razor"
       
    public List<Post> posts { get; set; }
    public string Message = null;
    public bool ShowMessage = false;
    private Task<AuthenticationState> authState;
    public string CurrentUserId = null;
    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        CurrentUserId = authState.User.Claims.Where(p => p.Type == "CurrentUserId").Select(c => c.Value).FirstOrDefault();

        var result = await postRepository.GetPosts();
        ShowMessage = true;
        if (result.Status)
        {
            if (result.Response != null)
            {
                if (result.Response.Count > 0)
                {
                    Message = $"Number Of Posts {result.Response.Count}";
                    posts = result.Response;
                }
                else
                {
                    Message = "Number Of Posts 0";
                    posts = new List<Post>();
                }
            }
            else
            {
                Message = $"Pending...";
            }

        }
        else
        {
            Message = "Http Error";
            posts = new List<Post>();
        }
    }
    private async Task DeletePost(int id)
    {
        var result = await postRepository.DeletePost(id);
        ShowMessage = true;
        if (result.Status)
        {
            posts.Remove(posts.FirstOrDefault(p => p.Id == id));
            Message = "Deleted !";
        }
        else
        {
            Message = "Failed !";
        }
    }
    private void EditPost(int id)
    {
        navigation.NavigateTo($"/post/edit/{id}");
    }
    private void ShowDetail(int id)
    {
        navigation.NavigateTo($"/post/detail/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostRepository postRepository { get; set; }
    }
}
#pragma warning restore 1591