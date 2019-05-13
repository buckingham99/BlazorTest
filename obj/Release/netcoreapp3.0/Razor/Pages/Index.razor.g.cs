#pragma checksum "C:\Develop\GitHub\BlazorTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8795d7865dada8522aa7fe5f2d93c9039742455"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<HeadingComponent></HeadingComponent>\r\n\r\n");
            builder.AddMarkupContent(1, "<h2>Blazor Test by Mark Buckingham</h2>\r\n");
            builder.AddMarkupContent(2, "<p>This is a test of using <b>Client Side</b> <u>Blazor Components</u></p>\r\n\r\n");
            builder.AddMarkupContent(3, "<p>This is the standard Blazor Client side template and it\'s been extended from there.</p>\r\n\r\n");
            builder.AddMarkupContent(4, "<p>\r\n    I didn\'t want to load up a MDF file for the database, so I used a CSV file from FakeNames.Com for data.\r\n    (Located in the Data folder).\r\n</p>\r\n");
            builder.AddMarkupContent(5, @"<p>
    The Test Users page is a grid that parses a CSV or JSON file via a Users Service
    to creates a list of users that is persisted in a Memory Cache.  You can Sort or Search 
    the grid

    This page also takes advantage of invoking JavaScript to handle a standard Bootstrap Modal.
    Changes can be made and will persist throughout the session, they will go away
    once you've navigated away from the site.
    You can easily add a database to this via the Names Service and persist the data.
</p>");
        }
        #pragma warning restore 1998
#line 30 "C:\Develop\GitHub\BlazorTest\Pages\Index.razor"
            
    List<User> users = new List<User>();
    string SortField = "Surname";
    bool SortDesc = false;

    protected async Task OnRenderAsync()
    {
        //users = await UserService.GetNamesJsonAsync(SortField, SortDesc);
        users = await UserService.GetNamesDataAsync(SortField, SortDesc);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService UserService { get; set; }
    }
}
#pragma warning restore 1591
