using System.Collections.Generic;

namespace AutoComplete.Models
{
    public class Repositories
    {
        public static IList<Country> FindAllCountries()
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
        public static IList<Airport> FindAllAirports()
        {
            return new List<Airport>()
            {
                new Airport() {AirportCode = "FCO", Name = "Rome Fiumicino"},
                new Airport() {AirportCode = "IAD", Name = "Washington Dulles"},
                new Airport() {AirportCode = "LHR", Name = "London Heathrow"},
                new Airport() {AirportCode = "SVO", Name = "Moscow Sheremetyevo"},
                new Airport() {AirportCode = "SYD", Name = "Sydney Kingsford Smith"}
            };
        } 
    }
}