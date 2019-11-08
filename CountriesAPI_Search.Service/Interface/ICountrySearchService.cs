using CountriesAPI_Search.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Service.Interface
{
    public interface ICountrySearchService
    {
        Task<List<CountrySearchResult>> GetSearchResultFromCountryName(string countryName);
    }
}
