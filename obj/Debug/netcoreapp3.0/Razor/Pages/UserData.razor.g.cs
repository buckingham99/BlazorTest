#pragma checksum "C:\Develop\BlazorTest\BlazorTest\Pages\UserData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46370359296ea254f33b932a4e2ae6ff49516829"
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdata")]
    public class UserData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>User Data</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service via local CSV file using a Telerik Grid.</p>\r\n\r\n");
#line 13 "C:\Develop\BlazorTest\BlazorTest\Pages\UserData.razor"
 if (users == null)
        {

#line default
#line hidden
            builder.AddContent(2, "            ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 16 "C:\Develop\BlazorTest\BlazorTest\Pages\UserData.razor"
        }
        else
        {

#line default
#line hidden
            builder.AddContent(4, "        ");
            __Blazor.BlazorTest.Pages.UserData.TypeInference.CreateTelerikGrid_0(builder, 5, 6, users, 7, true, 8, 50, 9, true, 10, (builder2) => {
                builder2.AddMarkupContent(11, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(12);
                builder2.AddAttribute(13, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.Surname)));
                builder2.AddAttribute(14, "Title", "Last Name");
                builder2.CloseComponent();
                builder2.AddMarkupContent(15, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(16);
                builder2.AddAttribute(17, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.GivenName)));
                builder2.AddAttribute(18, "Title", "First Name");
                builder2.CloseComponent();
                builder2.AddMarkupContent(19, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(20);
                builder2.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.StreetAddress)));
                builder2.AddAttribute(22, "Title", "Address");
                builder2.CloseComponent();
                builder2.AddMarkupContent(23, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(24);
                builder2.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.City)));
                builder2.AddAttribute(26, "Title", "City");
                builder2.CloseComponent();
                builder2.AddMarkupContent(27, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(28);
                builder2.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.State)));
                builder2.AddAttribute(30, "Title", "State");
                builder2.CloseComponent();
                builder2.AddMarkupContent(31, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(32);
                builder2.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.ZipCode)));
                builder2.AddAttribute(34, "Title", "Zip Code");
                builder2.CloseComponent();
                builder2.AddMarkupContent(35, "\r\n                ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(36);
                builder2.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(User.TelephoneNumber)));
                builder2.AddAttribute(38, "Title", "Phone");
                builder2.CloseComponent();
                builder2.AddMarkupContent(39, "\r\n            ");
            }
            );
            builder.AddMarkupContent(40, "\r\n");
#line 30 "C:\Develop\BlazorTest\BlazorTest\Pages\UserData.razor"
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 32 "C:\Develop\BlazorTest\BlazorTest\Pages\UserData.razor"
            
    //int recordsToReturn = 200;
    List<User> users = new List<User>();
    //int namesCount = 0;
    string SortField = "Id";
    bool SortDesc = false;
    string SurnameSort = String.Empty;
    string GivenNameSort = String.Empty;
    string StreetAddressSort = String.Empty;
    string CitySort = String.Empty;
    string StateSort = String.Empty;
    string ZipCodeSort = String.Empty;


    protected override async Task OnInitAsync()
    {
        users = await namesService.GetNamesDataAsync(SortField, SortDesc);
    }
    //protected override async Task OnAfterRenderAsync()
    //{
    //    users = await namesService.GetNamesDataAsync(SortField, SortDesc);
    //    ShouldRender();
    //    //users = namesService.GetNamesData(SortField, SortDesc);
    //}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NamesService namesService { get; set; }
    }
}
namespace __Blazor.BlazorTest.Pages.UserData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, System.Boolean __arg1, int __seq2, System.Int32 __arg2, int __seq3, System.Boolean __arg3, int __seq4, Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        builder.OpenComponent<global::Telerik.Blazor.Components.Grid.TelerikGrid<TItem>>(seq);
        builder.AddAttribute(__seq0, "Data", __arg0);
        builder.AddAttribute(__seq1, "Pageable", __arg1);
        builder.AddAttribute(__seq2, "PageSize", __arg2);
        builder.AddAttribute(__seq3, "Sortable", __arg3);
        builder.AddAttribute(__seq4, "TelerikGridColumns", __arg4);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
