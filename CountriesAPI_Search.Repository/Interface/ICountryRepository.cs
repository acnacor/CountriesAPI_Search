using CountriesAPI_Search.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Repository.Interface
{
    interface ICountryRepository
    {
        Task<List<CountrySearchResult>> GetSearchResultFromCountryName(string countryName);
    }
}
}
