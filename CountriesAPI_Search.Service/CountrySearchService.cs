using CountriesAPI_Search.Domain.ViewModel;
using CountriesAPI_Search.Repository.Interface;
using CountriesAPI_Search.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Service
{
    class CountrySearchService : ICountrySearchService
    {
        private readonly ICountryRepository _countryRepository;

        public CountrySearchService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public Task<List<CountryViewModel>> GetSearchResultFromCountryName(string countryName)
        {
            throw new NotImplementedException();
        }

    }
}
