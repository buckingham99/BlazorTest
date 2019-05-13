using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlazorTest.Models;
using System.Runtime.Caching;
using Newtonsoft.Json;

namespace BlazorTest.Services
{
    public class UserService
    {
        private const string CacheKey = "users";
        private const int UsersToReturn = 250;
        private const string FileNameCSV = @"\Data\FakeNames.csv";
        private const string FileNameJSON = @"\Data\FakeNames.json";

        public int UsersCount()
        {
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains(CacheKey))
            {
                List<User> users = (List<User>)cache.Get(CacheKey);
                return users.Count;
            }
            else
            {
                return 0;
            }
        }

        public List<User> GetNamesData(string SortField, bool SortDesc)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            if (cache.Contains(CacheKey))
                return (List<User>)cache.Get(CacheKey);
            else
            {
                List<User> users = ReadCSVFile();
                if (users.Count > 0)
                {
                    cacheItemPolicy = CacheItemPolicy(users);
                }
                users = SortNamesData(SortField, SortDesc, users);
                return users;
            }
        }
        public async Task<List<User>> GetNamesDataAsync(string SortField, bool SortDesc)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            if (cache.Contains(CacheKey))
                return await Task.FromResult((List<User>)cache.Get(CacheKey));
            else
            {
                List<User> users = await ReadCSVFileAsync();

                users = await SortNamesDataAsync(SortField, SortDesc, users);
                if (users.Count > 0)
                {
                    cacheItemPolicy = await CacheItemPolicyAsync(users);
                }
                
                return await Task.FromResult(users.ToList());
            }
        }

        public List<User> GetNamesJson(string SortField, bool SortDesc)
        {
            var path = Path.GetDirectoryName(Assembly
                .GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly()
                .Location.IndexOf("bin\\")));
            ObjectCache cache = MemoryCache.Default;
            using (StreamReader r = new StreamReader(path + FileNameJSON))
            {
                string json = r.ReadToEnd();
                if (cache.Contains(CacheKey))
                    return (List<User>)cache.Get(CacheKey);
                else
                {
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                    users = SortNamesData(SortField, SortDesc, users);
                    CacheItemPolicy cacheItemPolicy = CacheItemPolicy(users);
                    return users.ToList();
                }
            }
        }
        public async Task<List<User>> GetNamesJsonAsync(string SortField, bool SortDesc)
        {
            var path = Path.GetDirectoryName(Assembly
                .GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly()
                .Location.IndexOf("bin\\")));
            ObjectCache cache = MemoryCache.Default;
            using (StreamReader r = new StreamReader(path + FileNameJSON))
            {
                string json = r.ReadToEnd();
                if (cache.Contains(CacheKey))
                    return (List<User>)cache.Get(CacheKey);
                else
                {
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                    users = await SortNamesDataAsync(SortField, SortDesc, users);
                    CacheItemPolicy cacheItemPolicy = await CacheItemPolicyAsync(users);
                    return await Task.FromResult(users.ToList());
                }
            }
        }
        private List<User> Sort(string SortField, bool SortDesc, List<User> users)
        {
            List<User> tmpUser = users;
            if (SortDesc == false)
                tmpUser = users.OrderBy(s => s.GetType().GetProperty(SortField).GetValue(s)).ToList();
            else
                tmpUser = users.OrderByDescending(s => s.GetType()
                .GetProperty(SortField)
                .GetValue(s))
                .ToList();
            return tmpUser;
        }
        public List<User> SortNamesData(string SortField, bool SortDesc, List<User> users)
        {
            return Sort(SortField, SortDesc, users);
        }
        public async Task<List<User>> SortNamesDataAsync(string SortField, bool SortDesc, List<User> users)
        {
            return await Task.FromResult(Sort(SortField, SortDesc, users));
        }

        public async Task<List<User>> SaveUserAsync(string SortField, bool SortDesc, List<User> users, User SelectedUser)
        {
            foreach (var x in users)
            {
                if (x.Id == SelectedUser.Id)
                {
                    x.GivenName = SelectedUser.GivenName;
                    x.Age = SelectedUser.Age;
                    x.Birthday = SelectedUser.Birthday;
                    x.BloodType = SelectedUser.BloodType;
                    x.CCExpires = SelectedUser.CCExpires;
                    x.CCNumber = SelectedUser.CCNumber;
                    x.CCType = SelectedUser.CCType;
                    x.Centimeters = SelectedUser.Centimeters;
                    x.City = SelectedUser.City;
                    x.Color = SelectedUser.Color;
                    x.Company = SelectedUser.Company;
                    x.CountryCode = SelectedUser.CountryCode;
                    x.CountryFull = SelectedUser.CountryFull;
                    x.CVV2 = SelectedUser.CVV2;
                    x.Domain = SelectedUser.Domain;
                    x.EmailAddress = SelectedUser.EmailAddress;
                    x.FeetInches = SelectedUser.FeetInches;
                    x.Gender = SelectedUser.Gender;
                    x.GivenName = SelectedUser.GivenName;
                    x.GUID = SelectedUser.GUID;
                    x.Kilograms = SelectedUser.Kilograms;
                    x.Latitude = SelectedUser.Latitude;
                    x.Longitude = SelectedUser.Longitude;
                    x.MiddleInitial = SelectedUser.MiddleInitial;
                    x.MoneyGramMTCN = SelectedUser.MoneyGramMTCN;
                    x.MothersMaiden = SelectedUser.MothersMaiden;
                    x.NameSet = SelectedUser.NameSet;
                    x.NationalID = SelectedUser.NationalID;
                    x.Occupation = SelectedUser.Occupation;
                    x.Password = SelectedUser.Password;
                    x.Pounds = SelectedUser.Pounds;
                    x.State = SelectedUser.State;
                    x.StateFull = SelectedUser.StateFull;
                    x.StreetAddress = SelectedUser.StreetAddress;
                    x.Surname = SelectedUser.Surname;
                    x.TelephoneCountryCode = SelectedUser.TelephoneCountryCode;
                    x.TelephoneNumber = SelectedUser.TelephoneNumber;
                    x.Title = SelectedUser.Title;
                    x.TropicalZodiac = SelectedUser.TropicalZodiac;
                    x.UPS = SelectedUser.UPS;
                    x.Username = SelectedUser.Username;
                    x.Vehicle = SelectedUser.Vehicle;
                    x.WesternUnionMTCN = SelectedUser.WesternUnionMTCN;
                    x.ZipCode = SelectedUser.ZipCode;
                }
            }

            ObjectCache cache = MemoryCache.Default;
            List<string> cacheKeys = cache.Select(kvp => kvp.Key).ToList();
            foreach (string cacheKey in cacheKeys)
            {
                cache.Remove(cacheKey);
            }
            CacheItemPolicy cacheItemPolicy = await CacheItemPolicyAsync(users);
            SortNamesData(SortField, SortDesc, users);
            return await Task.FromResult(users.ToList());
        }

        private CacheItemPolicy CacheItemPolicy(List<User> users)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddHours(6.0)
            };
            cache.Add(CacheKey, users, cacheItemPolicy);
            return cacheItemPolicy;
        }
        private async Task<CacheItemPolicy> CacheItemPolicyAsync(List<User> users)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddHours(6.0)
            };
            cache.Add(CacheKey, users, cacheItemPolicy);
            return await Task.FromResult(cacheItemPolicy);
        }

        private List<User> ReadCSVFile()
        {

            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.IndexOf("bin\\")));
            string[] lines = File.ReadAllLines(path + FileNameCSV);
            List<User> users = ConvertCSVToUsers(lines);
            return users;
        }
        private async Task<List<User>> ReadCSVFileAsync()
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.IndexOf("bin\\")));
            string[] lines = File.ReadAllLines(path + FileNameCSV);
            List<User> users = await ConvertCSVToUsersAsync(lines);
            return await Task.FromResult(users);
        }

        private List<User> ConvertCSVToUsers(string[] lines)
        {
            List<User> users = new List<User>();
            List<string> list_lines = new List<string>(lines);
            Parallel.ForEach(list_lines, line =>
            {
                var t = line.Split(',');
                // Skip the First Line to leave the CSV file from FakeNames.Com intact
                if (t[0] != "Number")
                {
                    User myUser = new User
                    {
                        Id = Convert.ToInt16(t[0]),
                        Gender = t[1],
                        NameSet = t[2],
                        Title = t[3],
                        GivenName = t[4],
                        MiddleInitial = t[5],
                        Surname = t[6],
                        StreetAddress = t[7],
                        City = t[8],
                        State = t[9],
                        StateFull = t[10],
                        ZipCode = t[11].Length == 5 ? t[11] : t[11].PadLeft(5 - t[11].Length, '0'),
                        CountryCode = t[12],
                        CountryFull = t[13],
                        EmailAddress = t[14],
                        Username = t[15],
                        Password = t[16],
                        TelephoneNumber = t[17],
                        TelephoneCountryCode = int.Parse(t[18]),
                        MothersMaiden = t[19],
                        Birthday = t[20],
                        Age = Convert.ToInt16(t[21]),
                        TropicalZodiac = t[22],
                        CCType = t[23],
                        CCNumber = Convert.ToDouble(t[24]).ToString().Substring(0, 5) + "?",
                        CVV2 = Convert.ToInt16(t[25]),
                        CCExpires = Convert.ToDateTime(t[26]).ToString("MM/yyyy"),
                        NationalID = t[27],
                        UPS = t[28],
                        WesternUnionMTCN = Convert.ToDecimal(t[29]),
                        MoneyGramMTCN = Convert.ToInt32(t[30]),
                        Color = t[31],
                        Occupation = t[32],
                        Company = t[33],
                        Vehicle = t[34],
                        Domain = t[35],
                        BloodType = t[36],
                        Pounds = t[37],
                        Kilograms = t[38],
                        FeetInches = t[39],
                        Centimeters = t[40],
                        GUID = t[41],
                        Latitude = t[42],
                        Longitude = t[43]

                    };
                        if(users.Count < UsersToReturn && myUser != null)
                            users.Add(myUser);
                }
            });

            return users;
        }
        private async Task<List<User>> ConvertCSVToUsersAsync(string[] lines)
        {
            List<User> users = new List<User>();
            List<string> list_lines = new List<string>(lines);
            Parallel.ForEach(list_lines, line =>
            {
                var t = line.Split(',');
                // Skip the First Line to leave the CSV file from FakeNames.Com intact
                if (t[0] != "Number")
                {
                    User myUser = new User
                    {
                        Id = Convert.ToInt16(t[0]),
                        Gender = t[1],
                        NameSet = t[2],
                        Title = t[3],
                        GivenName = t[4],
                        MiddleInitial = t[5],
                        Surname = t[6],
                        StreetAddress = t[7],
                        City = t[8],
                        State = t[9],
                        StateFull = t[10],
                        ZipCode = t[11].Trim().Length == 5 ? t[11] : t[11].PadRight(5 - t[11].Length, '0'),
                        CountryCode = t[12],
                        CountryFull = t[13],
                        EmailAddress = t[14],
                        Username = t[15],
                        Password = t[16],
                        TelephoneNumber = t[17],
                        TelephoneCountryCode = int.Parse(t[18]),
                        MothersMaiden = t[19],
                        Birthday = t[20],
                        Age = Convert.ToInt16(t[21]),
                        TropicalZodiac = t[22],
                        CCType = t[23],
                        CCNumber = Convert.ToDouble(t[24]).ToString().Substring(0, 5) + "?",
                        CVV2 = Convert.ToInt16(t[25]),
                        CCExpires = Convert.ToDateTime(t[26]).ToString("MM/yyyy"),
                        NationalID = t[27],
                        UPS = t[28],
                        WesternUnionMTCN = Convert.ToDecimal(t[29]),
                        MoneyGramMTCN = Convert.ToInt32(t[30]),
                        Color = t[31],
                        Occupation = t[32],
                        Company = t[33],
                        Vehicle = t[34],
                        Domain = t[35],
                        BloodType = t[36],
                        Pounds = t[37],
                        Kilograms = t[38],
                        FeetInches = t[39],
                        Centimeters = t[40],
                        GUID = t[41],
                        Latitude = t[42],
                        Longitude = t[43]

                    };
                    if (users.Count < UsersToReturn)
                        users.Add(myUser);
                }
            });
            return await Task.FromResult(users);
        }
    }
}

