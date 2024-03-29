﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CountriesAPI_Search.Service;
using CountriesAPI_Search.Repository.Interface;
using CountriesAPI_Search.Repository;
using CountriesAPI_Search.Service.Interface;

namespace CountriesAPI_Search
{
    public class Startup
    {

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<ICountrySearchService, CountrySearchService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                            routes.MapRoute(
                name: "default",
                template: "{action}/{id?}",
                defaults: new { controller = "Country", action = "Index" });

            });
        }
    }
}
