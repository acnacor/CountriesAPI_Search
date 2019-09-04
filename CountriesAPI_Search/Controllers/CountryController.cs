﻿using CountriesAPI_Search.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Controllers
{
    public class CountryController
    {
        private readonly ICountrySearchService _countryService;

        public CountryController(ICountrySearchService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IActionResult> Index(string countryName)
        {

            if (!string.IsNullOrWhiteSpace(countryName))
            {
                var result = await _countryService.GetSearchResultFromCountryName(countryName);

                ViewData["search"] = countryName;

                return View(result);
            }

            return View(new List<CountryViewModel>());


        }
    }
}
