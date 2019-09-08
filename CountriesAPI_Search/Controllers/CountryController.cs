using CountriesAPI_Search.Domain.ViewModel;
using CountriesAPI_Search.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountrySearchService _countryService;

        public CountryController(ICountrySearchService countryService)
        {
            _countryService = countryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string countryName)
        {
            if (!string.IsNullOrWhiteSpace(countryName))
            {
                ViewData["query"] = countryName;
                var result = await _countryService.GetSearchResultFromCountryName(countryName);

                if (result != null)
                {

                    // Ignore case of of the query and returns country that starts with the query instead of contains
                    // Query: A
                    // Before: result = Countries' that contains the letter 'a' anywhere in their name
                    // After: result = Countries that starts with 'a'
                    var filteredResult = result.Where(y => y.Name.StartsWith(countryName,StringComparison.CurrentCultureIgnoreCase)).ToList();
                    return View(filteredResult);
                }
                   
            }

                return View(new List<CountryViewModel>());

            }


    }
}
