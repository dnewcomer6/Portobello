using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using AutoComplete.Common.SearchEngines;
using Expoware.Portobello.AutoComplete;

namespace AutoComplete
{
    public class MvcApplication : HttpApplication
    {
        public static IAutoCompleteEngine IndexEngine { get; set; }

        protected void Application_Start()
        {
            var countriesToSearch = FindAllCountries();

            IndexEngine = new DefaultAutoCompleteEngine()
                .AddSearchEngine(
                    new CollectionSearchEngine<Country>(countriesToSearch,
                        c => new AutoCompleteItem()
                        {
                            value = String.Format("{0} - <b>{1}</b>", c.Name, c.Code),
                            id = c.Code,
                            label = c.Name
                        },
                        c => c.Name, c => c.Currency));

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private IList<Country> FindAllCountries()
        {
            return new List<Country>()
            {
                new Country() {Capital = "Rome", Code="ITA", Currency = "EUR", Name="Italy", TimeZone = "+1"},
                new Country() {Capital = "Washington", Code="USA", Currency = "USD", Name="United States", TimeZone = "-6-9"},
                new Country() {Capital = "London", Code="UK", Currency = "GBP", Name="United Kingdom", TimeZone = "0"},
                new Country() {Capital = "France", Code="FRA", Currency = "EUR", Name="France", TimeZone = "+1"},
                new Country() {Capital = "Canberra", Code="AUS", Currency = "AUD", Name="Australia", TimeZone = "+8+10"},
            };
        }

    }
}
