using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Models;
namespace BlazorTest.Services
{
    public interface IUserService 
    {
        List<User> GetNamesData(string SortField, bool SortDesc);
        Task<List<User>> GetNamesDataAsync(string SortField, bool SortDesc);
        Task<List<User>> SortNamesData(string SortField, bool SortDesc, List<User> users);
        Task<List<User>> SortNamesDataAsync(string SortField, bool SortDesc, List<User> users);
        Task<List<User>> SaveUserAsync(string SortField, bool SortDesc, List<User> users, User SelectedUser);
        int UsersCount { get; set; }
    }
}
