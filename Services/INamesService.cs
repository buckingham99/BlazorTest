using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Models;
namespace BlazorTest.Services
{
    public interface INamesService
    {
        Task<List<User>> GetNamesDataAsync(string SortField, bool SortDesc);
        Task<List<User>> SortNamesDataAsync(string SortField, bool SortDesc, List<User> users);
    }
}
