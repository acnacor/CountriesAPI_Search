
using CountriesAPI_Search.Domain.Models;
using CountriesAPI_Search.Repository.Interface;
using CountriesAPI_Search.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Service
{
    public class CountrySearchService : ICountrySearchService
    {
        private readonly ICountryRepository _countryRepository;

        public CountrySearchService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<List<CountrySearchResult>> GetSearchResultFromCountryName(string countryName)
        {
            var searchResult = await _countryRepository.GetSearchResultFromCountryName(countryName);

            return searchResult;


        }

    }
}
