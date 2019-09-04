using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesAPI_Search.Domain.ViewModel
{
    public class CountryViewModel
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public ulong Population { get; set; }
        public string Demonym { get; set; }
        public Uri Flag { get; set; }
    }
}
