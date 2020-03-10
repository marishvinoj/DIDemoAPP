using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public class CountryManager : ICountryManager
    {
        public IList<string> GetCountryList() 
            => new string[] { "India", "US" };
    }
}
