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
        private const string FileNameCSV = "Data//FakeNames.csv";
        private const string FileNameJSON = "Data//FakeNames.json";
        public int UsersCount {get;set;}
        public static List<User> users = new List<User>();

        public List<User> GetNamesData(string SortField, bool SortDesc)
        {
                users = ReadCSVFile();
                users = SortNamesData(SortField, SortDesc, users);
                UsersCount = users.Count;
                return users;
        }
        public async Task<List<User>> GetNamesDataAsync(string SortField, bool SortDesc)
        {
                users = await ReadCSVFileAsync();
                UsersCount = users.Count;
                users = await SortNamesDataAsync(SortField, SortDesc, users);
                return await Task.FromResult(users.ToList());
        }

        public List<User> GetNamesJson(string SortField, bool SortDesc)
        {
            using (StreamReader r = new StreamReader(FileNameJSON))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(json);
                UsersCount = users.Count;
                users = SortNamesData(SortField, SortDesc, users);
                UsersCount = users.Count;

                return users.ToList();
            }
        }
        public async Task<List<User>> GetNamesJsonAsync(string SortField, bool SortDesc)
        {
            using (StreamReader r = new StreamReader(FileNameJSON))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(json);
                UsersCount = users.Count;
                users = await SortNamesDataAsync(SortField, SortDesc, users);
                return await Task.FromResult(users.ToList());
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

            SortNamesData(SortField, SortDesc, users);
            return await Task.FromResult(users.ToList());
        }

        private List<User> ReadCSVFile()
        {
            string[] lines = File.ReadAllLines(FileNameCSV);
            users = ConvertCSVToUsers(lines);
            return users;
        }
        private async Task<List<User>> ReadCSVFileAsync()
        {
            string[] lines = File.ReadAllLines(FileNameCSV);
            users = await ConvertCSVToUsersAsync(lines);
            return await Task.FromResult(users);
        }

        private List<User> ConvertCSVToUsers(string[] lines)
        {
            users.Clear();
            List<string> list_lines = new List<string>(lines);
            Parallel.ForEach(list_lines, line =>
            {
                var t = line.Split(',');
                // Skip the First Line to leave the CSV file from FakeNames.Com intact
                if (t[0] != "Number")
                {
                    User myUser = new User
                    {
                        Id = t[0],
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
                        ZipCode = (t[11].Length) == 5 ? t[11] : "0" + t[11],
                        CountryCode = t[12],
                        CountryFull = t[13],
                        EmailAddress = t[14],
                        Username = t[15],
                        Password = t[16],
                        TelephoneNumber = t[17],
                        TelephoneCountryCode = t[18],
                        MothersMaiden = t[19],
                        Birthday = t[20],
                        Age = t[21],
                        TropicalZodiac = t[22],
                        CCType = t[23],
                        CCNumber = t[24],
                        CVV2 = t[25],
                        CCExpires = t[26],
                        NationalID = t[27],
                        UPS = t[28],
                        WesternUnionMTCN = t[29],
                        MoneyGramMTCN = t[30],
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
                    users.Add(myUser);
                }
            });

            return users;
        }
        private async Task<List<User>> ConvertCSVToUsersAsync(string[] lines)
        {
            users.Clear();
            List<string> list_lines = new List<string>(lines);
            Parallel.ForEach(list_lines, line =>
            {
                var t = line.Split(',');
                // Skip the First Line to leave the CSV file from FakeNames.Com intact
                if (t[0] != "Number")
                {
                    User myUser = new User
                    {
                        Id = t[0],
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
                        TelephoneCountryCode = t[18],
                        MothersMaiden = t[19],
                        Birthday = t[20],
                        Age = t[21],
                        TropicalZodiac = t[22],
                        CCType = t[23],
                        CCNumber = t[24],
                        CVV2 = t[25],
                        CCExpires = t[26],
                        NationalID = t[27],
                        UPS = t[28],
                        WesternUnionMTCN = t[29],
                        MoneyGramMTCN = t[30],
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
                    users.Add(myUser);
                }
            });
            UsersCount = users.Count;
            return await Task.FromResult(users);
        }
    }
}

