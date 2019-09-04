using CountriesAPI_Search.Domain.ViewModel;
using CountriesAPI_Search.Service.Interface;
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


        public IActionResult Index(string countryName)
        {
            return RedirectToAction("DisplayCountry",countryName);
        }

        public async Task<IActionResult> DisplayCountry(string countryName)
        {

            if (!string.IsNullOrWhiteSpace(countryName))
            {
                var result = await _countryService.GetSearchResultFromCountryName(countryName);

                ViewData["query"] = countryName;

                if (result != null)
                {
                    return View(result);
                }
                else
                {
                    return View(new List<CountryViewModel>());
                }


            }

            return View(new List<CountryViewModel>());

        }

    }
}
