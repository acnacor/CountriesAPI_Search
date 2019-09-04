using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CountriesAPI_Search.Domain.Models;
using CountriesAPI_Search.Domain.ViewModel;

namespace CountriesAPI_Search.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CountrySearchResult, CountryViewModel>(MemberList.None);
        }
    }
}
