using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CountriesAPI_Search.Repository.Models
{
    public class CountrySearchResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("population")]
        public ulong Population { get; set; }

        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        [JsonProperty("flag")]
        public Uri Flag { get; set; }
    }
}
