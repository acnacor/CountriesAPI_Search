using AutoMapper;
using CountriesAPI_Search.Domain.ViewModel;
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
        private readonly IMapper _mapper;

        public CountrySearchService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<List<CountryViewModel>> GetSearchResultFromCountryName(string countryName)
        {
            var searchResult = await _countryRepository.GetSearchResultFromCountryName(countryName);
            return _mapper.Map<List<CountryViewModel>>(searchResult);
        }

    }
}
