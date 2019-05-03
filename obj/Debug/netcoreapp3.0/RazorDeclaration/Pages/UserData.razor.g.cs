#pragma checksum "C:\Develop\GitHub\BlazorTest\Pages\UserData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4c21d8177bca94c91b178ad7f496026e7114e9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorTest.Shared;
    using BlazorTest.Services;
    using BlazorTest.Models;
    using System.Collections.Generic;
    using System.Linq;
    using Telerik.Blazor.Components.Grid;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdata")]
    public class UserData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 33 "C:\Develop\GitHub\BlazorTest\Pages\UserData.razor"
            

    List<User> users = new List<User>();
    string SortField = "Id";
    bool SortDesc = false;

    protected override async Task OnInitAsync()
    {
        users = await namesService.GetNamesDataAsync(SortField, SortDesc);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NamesService namesService { get; set; }
    }
}
#pragma warning restore 1591
