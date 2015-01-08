using System.Collections.Generic;
using Expoware.Portobello.AutoComplete;

namespace AutoComplete.Controllers.Services
{
    public class HintService
    {
        public IEnumerable<AutoCompleteItem> GetHints(string query)
        {
            return MvcApplication.IndexEngine.GetHints(query);
        }
    }
}