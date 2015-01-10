using System.Collections.Generic;
using AutoComplete.Models;
using Expoware.Portobello.AutoComplete;

namespace AutoComplete.Controllers.Services
{
    public class HintService
    {
        public IEnumerable<AutoCompleteItem> GetHintsForS(string query)
        {
            return MvcApplication.IndexEngine1.GetHints(query);
        }

        public IEnumerable<Country> GetHintsForT(string query)
        {
            return MvcApplication.IndexEngine2.GetData(query);
        }
    }
}