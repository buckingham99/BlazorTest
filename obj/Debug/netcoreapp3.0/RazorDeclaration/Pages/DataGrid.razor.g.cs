#pragma checksum "C:\Develop\GitHub\BlazorTest\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23423f2bfca1ea11370db41bb504be7953a6e9ad"
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
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorTest.Shared;
    using BlazorTest.Models;
    using BlazorTest.Services;
    using BlazorTest.Helpers;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.AspNetCore.Components;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    public class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 229 "C:\Develop\GitHub\BlazorTest\Pages\DataGrid.razor"
            
    int currentPage = 1;
    int pageSize = 20;

    List<User> users = new List<User>();
    List<User> displayUsers = new List<User>();
    public User UnModifiedUser = new User();
    User SelectedUser = new User();
    int namesCount = 0;
    string SortField = "Id";
    bool SortDesc = false;
    string SurnameSort = String.Empty;
    string GivenNameSort = String.Empty;
    string StreetAddressSort = String.Empty;
    string CitySort = String.Empty;
    string StateSort = String.Empty;
    string ZipCodeSort = String.Empty;
    string PhoneSort = String.Empty;
    string LoaderDisplayType = "block;";
    int TotalPages => users.Count > 0 ? (int)Math.Ceiling(decimal.Divide(users.Count, pageSize)) : 0;
    List<int> btnlist = new List<int>();

    protected override void OnInit()
    {
        ToggleSpinner(true);
        users = NamesService.GetNamesData(SortField, SortDesc);
        //namesCount = NamesService.GetUserCount();
        namesCount = users.Count;

        for (int i = 1; i < TotalPages + 1; i++)
        {
            btnlist.Add(i);
        }
        displayUsers = users.OrderByDescending(s => s.GetType()
        .GetProperty(SortField)
        .GetValue(s))
        .Skip((currentPage - 1) * pageSize)
        .Take(pageSize).ToList();
        ToggleSpinner(false);
        StateHasChanged();
    }

    void ChangePage(int newPage)
    {
        ToggleSpinner(true);
        currentPage = newPage;
        SortDesc = !SortDesc; //Reverse Sort so that the sort stays the same
        SortData(SortField);
        StateHasChanged();
        ToggleSpinner(false);

    }
    private void ToggleSpinner(bool spinnerOn)
    {
        LoaderDisplayType = (spinnerOn) ? "block;" : "none;";
    }

    private void SortData(string NewSort)
    {
        SortField = NewSort;
        ToggleSpinner(true);
        BlankDirectionIcons();
        SortDesc = !SortDesc;
        CalcIconDirection(SortField);
        if (SortDesc)
        {
            displayUsers = users.OrderByDescending(s => s.GetType()
            .GetProperty(SortField)
            .GetValue(s))
            .Skip((currentPage - 1) * pageSize)
            .Take(pageSize).ToList();
        }
        else
        {
            displayUsers = users.OrderBy(s => s.GetType()
            .GetProperty(SortField)
            .GetValue(s))
            .Skip((currentPage - 1) * pageSize)
            .Take(pageSize).ToList();
        }
        ToggleSpinner(false);
    }

    private string CalcIconDirection(string SortField)
    {
        string szDirection = SortDesc == true ? "oi oi-arrow-thick-bottom" : "oi oi-arrow-thick-top";
        switch (SortField)
        {
            case "Surname":
                SurnameSort = szDirection;
                return SurnameSort;
            case "GivenName":
                GivenNameSort = szDirection;
                return GivenNameSort;
            case "StreetAddress":
                StreetAddressSort = szDirection;
                return StreetAddressSort;
            case "City":
                CitySort = szDirection;
                return CitySort;
            case "State":
                StateSort = szDirection;
                return StateSort;
            case "TelephoneNumber":
                PhoneSort = szDirection;
                return PhoneSort;
            case "ZipCode":
                ZipCodeSort = szDirection;
                return ZipCodeSort;
            default:
                return String.Empty;
        }
    }
    void BlankDirectionIcons()
    {
        SurnameSort = "";
        GivenNameSort = "";
        StreetAddressSort = "";
        CitySort = "";
        StateSort = "";
        PhoneSort = "";
        ZipCodeSort = "";
    }

    private async void EditUser(User myUser)
    {
        SelectedUser = myUser;
        UnModifiedUser = Comparer.DeepCopy<User>(SelectedUser);

        await JSRuntime.InvokeAsync<string>(
                 "appFunctions.showEditUserModal", "");
        //StateHasChanged();
    }
    private async Task<List<User>> SaveUser(User SelectedUser)
    {
        //await JSRuntime.InvokeAsync<string>(
        //    "appfunctions.saveConfirmation", "");

        //await JSRuntime.InvokeAsync<string>(
        //    "appFunctions.hideEditUserModal", "");

        users = await NamesService.SaveUserAsync(SortField, SortDesc, users, SelectedUser, currentPage, pageSize);

        await JSRuntime.InvokeAsync<string>(
                "appFunctions.hideEditUserModal", "");

        ToggleSpinner(false);
        StateHasChanged();
        return users;
    }

    private async Task<List<User>> CancelSaveUser(User SelectedUser)
    {
        if (!Comparer.DeepCompare(SelectedUser, UnModifiedUser))
        {
            users = await NamesService.SaveUserAsync(SortField, SortDesc, users, UnModifiedUser, currentPage, pageSize);
        }


        SelectedUser = null;
        UnModifiedUser = null;

        await JSRuntime.InvokeAsync<string>(
            "appFunctions.hideEditUserModal", "");

        ToggleSpinner(false);
        //StateHasChanged();
        return users;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NamesService NamesService { get; set; }
    }
}
#pragma warning restore 1591
