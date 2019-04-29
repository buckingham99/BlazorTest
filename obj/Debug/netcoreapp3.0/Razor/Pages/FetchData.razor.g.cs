#pragma checksum "C:\Develop\BlazorTest\BlazorTest\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0881325e7caae1cd595adc9c542c1a140523fd2b"
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
    using BlazorTest.Data;
    using Telerik.Blazor.Components.Grid;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#line 11 "C:\Develop\BlazorTest\BlazorTest\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 14 "C:\Develop\BlazorTest\BlazorTest\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            __Blazor.BlazorTest.Pages.FetchData.TypeInference.CreateTelerikGrid_0(builder, 5, 6, forecasts, 7, true, 8, 5, 9, true, 10, (builder2) => {
                builder2.AddMarkupContent(11, "\r\n            ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(12);
                builder2.AddAttribute(13, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(WeatherForecast.Date)));
                builder2.AddAttribute(14, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (builder3) => {
                    builder3.AddMarkupContent(15, "\r\n                    ");
                    builder3.AddContent(16, $"{(context as WeatherForecast).Date:d}");
                    builder3.AddMarkupContent(17, "\r\n                ");
                }
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(18, "\r\n            ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(19);
                builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(WeatherForecast.TemperatureC)));
                builder2.CloseComponent();
                builder2.AddMarkupContent(21, "\r\n            ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(22);
                builder2.AddAttribute(23, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(WeatherForecast.TemperatureF)));
                builder2.CloseComponent();
                builder2.AddMarkupContent(24, "\r\n            ");
                builder2.OpenComponent<Telerik.Blazor.Components.Grid.TelerikGridColumn>(25);
                builder2.AddAttribute(26, "Field", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(WeatherForecast.Summary)));
                builder2.CloseComponent();
                builder2.AddMarkupContent(27, "\r\n        ");
            }
            );
            builder.AddMarkupContent(28, "\r\n");
#line 29 "C:\Develop\BlazorTest\BlazorTest\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 31 "C:\Develop\BlazorTest\BlazorTest\Pages\FetchData.razor"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BlazorTest.Pages.FetchData
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
