#pragma checksum "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c952a63b78cf5a8eee6e701a9dc41d5902070cc"
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
    public partial class ShowLikePosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
 if (likePosts != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3 class=\"text-left p-3\">🔥Trending 🔥</h3>");
#nullable restore
#line 8 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
     if (likePosts.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
#nullable restore
#line 11 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
             foreach (Post item in likePosts)
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
#line 16 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
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
#line 18 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
                                                    item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
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
#line 22 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
                                                                 item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddMarkupContent(23, "<strong>Likes :</strong> ");
            __builder.AddContent(24, 
#nullable restore
#line 26 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
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
#line 30 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
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
#line 32 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
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
#line 37 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<p class=\"alert alert-info text-center\">The List is Empty</p>");
#nullable restore
#line 44 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FinalBlazorIndivisualUser.Client.Shared.Loading>(40);
            __builder.CloseComponent();
#nullable restore
#line 49 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\User\Desktop\FinalBlazorIndivisualUser\FinalBlazorIndivisualUser\Client\Pages\PostComponents\ShowLikePosts.razor"
       
    public List<Post> likePosts { get; set; }
    private Task<AuthenticationState> authState;
    public string CurrentUserId = null;
    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        CurrentUserId = authState.User.Claims.Where(p => p.Type == "CurrentUserId").Select(c => c.Value).FirstOrDefault();

        var getLikePosts = await postRepository.GetPostsOrderByLike();

        if (getLikePosts.Status)
        {
            if (getLikePosts.Response != null)
            {
                if (getLikePosts.Response.Count > 0)
                {
                    likePosts = getLikePosts.Response;
                }
                else
                {
                    likePosts = new List<Post>();
                }
            }

        }
        else
        {
            likePosts = new List<Post>();
        }
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
