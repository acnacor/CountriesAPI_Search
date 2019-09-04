
using CountriesAPI_Search.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Repository.Interface
{
    public interface ICountryRepository
    {
        Task<List<CountrySearchResult>> GetSearchResultFromCountryName(string countryName);
    }
}
