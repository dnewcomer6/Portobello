﻿using System.Collections.Generic;
using System.Linq;
using Expoware.Portobello.Extensions;

namespace Expoware.Portobello.AutoComplete
{
    public class DefaultAutoCompleteEngine : IAutoCompleteEngine
    {
        protected readonly IList<ISearchEngine> Engines = new List<ISearchEngine>();

        public IAutoCompleteEngine AddSearchEngine(ISearchEngine engine)
        {
            Engines.Add(engine);
            return this;
        }

        public IEnumerable<AutoCompleteItem> GetHints(string[] tokens, int maxRows = 15, SearchType typeOfSearch = SearchType.Or)
        {
            var hints = new List<AutoCompleteItem>();
            foreach (var e in Engines)
            {
                if (!e.CanHandle(tokens)) continue;

                var searchEngineHints = e.GetHints(tokens, maxRows, typeOfSearch);
                hints.AddRange(searchEngineHints);
            }
            return hints;
        }

        public IEnumerable<AutoCompleteItem> GetHints(string token, int maxRows = 15, SearchType typeOfSearch = SearchType.Or)
        {
            var tokens = AutoCompleteHelpers.BreakUpQueryString(token);
            return GetHints(tokens);
        }


        #region VIRTUAL

        //protected virtual string[] BreakUpQueryString(string query)
        //{
        //    // Get the list of searchable tokens in the search string
        //    query = query.ToLower();
        //    query = query.ReplaceAny(" ", /* To be replaced */ ",", ";", "+", "*", "[", "]", "@");

        //    // Get the list of searchable tokens in the search string
        //    var tokens = query.ToLower().Split(' ');
        //    if (tokens.Length > 0)
        //    {
        //        tokens = tokens.Where(t => !t.IsNullOrWhitespace()).ToArray();
        //        return tokens;
        //    }
        //    return new[] { query };
        //}
        #endregion
    }
}