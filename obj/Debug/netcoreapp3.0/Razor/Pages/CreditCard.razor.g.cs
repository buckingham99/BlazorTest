#pragma checksum "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efabea0f0fbc9eea79c1c063061088cb2eb99551"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorTest.Shared;
    using Microsoft.AspNetCore.Components;
    using System;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/creditcard")]
    public class CreditCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddAttribute(1, "style", "display:none;");
            builder.AddContent(2, ChildContent);
            builder.CloseElement();
            builder.AddMarkupContent(3, "\r\n");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "style", "background-color:lightblue;display:" + (DisplayType));
            builder.AddMarkupContent(6, "\r\n    ");
            builder.AddMarkupContent(7, "<div>\r\n        <label><b><u>Credit Card Data:</u></b></label>\r\n    </div>\r\n    ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "style", "font-size:xx-small");
            builder.AddMarkupContent(10, "\r\n        ");
            builder.OpenElement(11, "table");
            builder.AddAttribute(12, "class", "table table-hover table-condensed table-bordered table-sm");
            builder.AddAttribute(13, "style", "font-size:xx-small");
            builder.AddMarkupContent(14, "\r\n            ");
            builder.OpenElement(15, "tbody");
            builder.AddMarkupContent(16, "\r\n                ");
            builder.AddMarkupContent(17, "<tr>\r\n                    <td><b>Female</b></td>\r\n                </tr>\r\n");
#line 16 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                 if (@_FemaleCardTypes.Count > 0)
                {

#line default
#line hidden
            builder.AddContent(18, "                    ");
            builder.OpenElement(19, "tr");
            builder.AddMarkupContent(20, "\r\n");
#line 19 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                         foreach (var u in @_FemaleCardTypes)
                        {

#line default
#line hidden
            builder.AddContent(21, "                            ");
            builder.OpenElement(22, "td");
            builder.OpenElement(23, "b");
            builder.AddContent(24, u.CardType.Trim().ToUpper());
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n");
#line 22 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                        }

#line default
#line hidden
            builder.AddContent(26, "                    ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n                    ");
            builder.OpenElement(28, "tr");
            builder.AddMarkupContent(29, "\r\n");
#line 25 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                         foreach (var u in @_FemaleCardTypes)
                        {

#line default
#line hidden
            builder.AddContent(30, "                            ");
            builder.OpenElement(31, "td");
            builder.AddContent(32, u.CardTypeTotalCount.ToString("#,##0"));
            builder.CloseElement();
            builder.AddMarkupContent(33, "\r\n");
#line 28 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                        }

#line default
#line hidden
            builder.AddContent(34, "                    ");
            builder.CloseElement();
            builder.AddMarkupContent(35, "\r\n");
#line 30 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                }

#line default
#line hidden
            builder.AddContent(36, "                ");
            builder.AddMarkupContent(37, "<tr>\r\n                    <td><b>Male</b></td>\r\n                </tr>\r\n");
#line 34 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                 if (@_MaleCardTypes.Count > 0)
                {

#line default
#line hidden
            builder.AddContent(38, "                    ");
            builder.OpenElement(39, "tr");
            builder.AddMarkupContent(40, "\r\n");
#line 37 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                         foreach (var u in _MaleCardTypes)
                        {

#line default
#line hidden
            builder.AddContent(41, "                        ");
            builder.OpenElement(42, "td");
            builder.OpenElement(43, "b");
            builder.AddContent(44, u.CardType.Trim());
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(45, "\r\n");
#line 40 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                        }

#line default
#line hidden
            builder.AddContent(46, "                    ");
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n                    ");
            builder.OpenElement(48, "tr");
            builder.AddMarkupContent(49, "\r\n");
#line 43 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                         foreach (var u in @_MaleCardTypes)
                        {

#line default
#line hidden
            builder.AddContent(50, "                            ");
            builder.OpenElement(51, "td");
            builder.AddContent(52, u.CardTypeTotalCount.ToString("#,##0"));
            builder.CloseElement();
            builder.AddMarkupContent(53, "\r\n");
#line 46 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                        }

#line default
#line hidden
            builder.AddContent(54, "                    ");
            builder.CloseElement();
            builder.AddMarkupContent(55, "\r\n");
#line 48 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
                }

#line default
#line hidden
            builder.AddContent(56, "            ");
            builder.CloseElement();
            builder.AddMarkupContent(57, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(58, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(59, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 54 "C:\Develop\GitHub\BlazorTest\Pages\CreditCard.razor"
            
    [Serializable]
    public class CardTypes
    {
        public string CardType { get; set; }
        public int CardTypeTotalCount { get; set; }
    }
    public List<CardTypes> cardTypes = new List<CardTypes>();

    [Parameter]
    private RenderFragment ChildContent { get; set; }

    List<CardTypes> _FemaleCardTypes = new List<CardTypes>();
    [Parameter]
    public IReadOnlyList<CardTypes> FemaleCardTypes
    {
        get { return _FemaleCardTypes; }
        set
        {
            if (value.Count > 0)
            {
                _FemaleCardTypes = value.ToList();
                onFemaleCardTypes();
            }
        }
    }
    List<CardTypes> _MaleCardTypes = new List<CardTypes>();
    [Parameter]
    public IReadOnlyList<CardTypes> MaleCardTypes
    {
        get { return _MaleCardTypes; }
        set
        {
            if (value.Count > 0)
            {
                _MaleCardTypes = value.ToList();
                onMaleCardTypes();
            }
        }
    }

    List<CardTypes> onMaleCardTypes()
    {
        ToggleDisplay(true);
        return _MaleCardTypes.ToList();
    }
    List<CardTypes> onFemaleCardTypes()
    {
        ToggleDisplay(true);
        return _FemaleCardTypes.ToList();
    }

    string DisplayType { get; set; }

    private string ToggleDisplay(bool spinnerOn)
    {
        DisplayType = (spinnerOn) ? "block;" : "none;";
        return DisplayType;
    }

    protected override void OnInit()
    {
        ToggleDisplay(false);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
