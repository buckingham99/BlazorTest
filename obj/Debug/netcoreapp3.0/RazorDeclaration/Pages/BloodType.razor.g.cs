#pragma checksum "C:\Develop\GitHub\BlazorTest\Pages\BloodType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a9e0bd0fa5ac8ef2fe32098edbd7c85942f7cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/bloodtype")]
    public class BloodType : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 49 "C:\Develop\GitHub\BlazorTest\Pages\BloodType.razor"
            
    [Serializable]
    public class BloodTypes
    {
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public int BloodTypeTotalCount { get; set; }
    }

    private List<BloodTypes> GenderName = new List<BloodTypes>();

    public List<BloodTypes> _bloodTypesList = new List<BloodTypes>();

    [Parameter]
    private RenderFragment ChildContent { get; set; }


    [Parameter]
    public IReadOnlyList<BloodTypes> bloodTypesList
    {
        get { return _bloodTypesList; }
        set
        {
            if (value.Count > 0)
            {
                
                _bloodTypesList = value.ToList();

                GenderName = _bloodTypesList.GroupBy(x => new { x.Gender })
                .Select(r => new BloodTypes
                {
                    Gender = r.Key.Gender
                })
                .OrderBy(r => r.Gender).ToList();
                ToggleDisplay(true);
                onBloodTypes();
            }
        }
    }

    List<BloodTypes> onBloodTypes()
    {
        ToggleDisplay(true);
        return _bloodTypesList.ToList();
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
