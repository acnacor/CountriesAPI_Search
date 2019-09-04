
using CountriesAPI_Search.Domain.HttpResponse;
using CountriesAPI_Search.Domain.Models;
using CountriesAPI_Search.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Repository
{
    public class CountryRepository : ICountryRepository
    {
        const string ApiUri = "https://restcountries.eu/rest/v2/name/";

        public async Task<List<CountrySearchResult>> GetSearchResultFromCountryName(string countryName)
        {
            var uri = new Uri(ApiUri + countryName + "/");

            var response = await Response.GetResponse(uri);

            return JsonConvert.DeserializeObject<List<CountrySearchResult>>(await response.Content.ReadAsStringAsync());

        }

    }
}
