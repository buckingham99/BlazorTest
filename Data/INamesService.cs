using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public interface INamesService
    {
        Task<List<User>> GetNamesDataAsync(string SortField, bool SortDesc);
        Task<List<User>> SortNamesDataAsync(string SortField, bool SortDesc, List<User> users);
    }
}
