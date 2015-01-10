using System;
using AutoComplete.Models;
using Expoware.Portobello.AutoComplete;

namespace AutoComplete.Common
{
    public class AutoCompleteConfig
    {
        public static IAutoCompleteEngine IndexEngine1()
        {
            var countriesToSearch = Repositories.FindAllCountries();
            var airportsToSearch = Repositories.FindAllAirports();

            var engine = new DefaultAutoCompleteEngine()
                .AddSearchEngine(
                    new CollectionSearchEngine<Country>(countriesToSearch,
                        c => new AutoCompleteItem()
                        {
                            value = String.Format("{0} : {1}", c.Code, c.Name),
                            id = "c-" + c.Code,
                            label = c.Name
                        },
                        c => c.Name, c => c.Currency))
                .AddSearchEngine(
                    new CollectionSearchEngine<Airport>(airportsToSearch,
                        a => new AutoCompleteItem()
                        {
                            value = a.Name,
                            id = "a-" + a.AirportCode,
                            label = a.Name
                        },
                        a => a.Name, a => a.AirportCode));

            return engine;
        }

        public static CollectionSearchEngine<Country> IndexEngine2()
        {
            var countriesToSearch = Repositories.FindAllCountries();
            return new CollectionSearchEngine<Country>(countriesToSearch,
                c => c.Name, c => c.Currency);
        }
    }
}