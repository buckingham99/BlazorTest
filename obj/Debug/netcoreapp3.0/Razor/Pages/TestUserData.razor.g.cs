#pragma checksum "C:\Develop\BlazorTest\BlazorTest\Pages\TestUserData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eaf17d7ecdfaa4401fcb1b3e1ff85df15f44de3"
// <auto-generated/>
#pragma warning disable 1591
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
    using BlazorTest.Data;
    using System.Collections.Generic;
    using System.Linq;
    using Telerik.Blazor.Components.Grid;
    using System.Text;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/testuserdata")]
    public class TestUserData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Test User Data</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<div style=\"border-color:aqua;\">\r\n    <p>This component demonstrates fetching data from a service via local CSV file using a HTML Grid.</p>\r\n</div>\r\n\r\n");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "style", "border-color:black;");
            builder.AddMarkupContent(4, "\r\n\r\n\r\n    ");
            builder.AddMarkupContent(5, "<div>\r\n        <p>Data within this Div is a hand made component</p>\r\n    </div>\r\n    ");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "style", "border-color:aqua;");
            builder.AddMarkupContent(8, "\r\n        ");
            builder.OpenComponent<BlazorTest.Pages.DataGrid>(9);
            builder.CloseComponent();
            builder.AddMarkupContent(10, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NamesService namesService { get; set; }
    }
}
#pragma warning restore 1591
