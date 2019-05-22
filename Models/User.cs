using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Models
{
    [Serializable]
    public class User
    {
        public int Number { get; set; }
        public string Gender { get; set; }
        public string NameSet { get; set; }
        public string Title { get; set; }
        public string GivenName { get; set; }
        public string MiddleInitial { get; set; }
        public string Surname { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StateFull { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string CountryFull { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }
        public int TelephoneCountryCode { get; set; }
        public string MothersMaiden { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public string TropicalZodiac { get; set; }
        public string CCType { get; set; }
        public string CCNumber { get; set; }
        public int CVV2 { get; set; }
        public string CCExpires { get; set; }
        public string NationalID { get; set; }
        public string UPS { get; set; }
        public Int64 WesternUnionMTCN { get; set; }
        public Int64 MoneyGramMTCN { get; set; }
        public string Color { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string Vehicle { get; set; }
        public string Domain { get; set; }
        public string BloodType { get; set; }
        public double Pounds { get; set; }
        public double Kilograms { get; set; }
        public string FeetInches { get; set; }
        public int Centimeters { get; set; }
        public string GUID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

}
