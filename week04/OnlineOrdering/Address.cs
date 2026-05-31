using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        // Method to determine if the address is in the USA
        public bool IsInUSA()
        {
            // Case-insensitive check to avoid string mismatch issues
            return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        }

        // Returns all fields formatted nicely with newlines
        public string GetFullAddress()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}