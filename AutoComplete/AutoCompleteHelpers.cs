using System.Collections.Generic;
using System.Linq;
using Expoware.Portobello.Extensions;

namespace Expoware.Portobello.AutoComplete
{
    public class AutoCompleteHelpers
    {
        //public static bool IsMatch(string targetText, ICollection<string> tokens, SearchType typeOfSearch = SearchType.Or)
        //{
        //    var normalized = targetText.ToLower();
        //    var count = tokens.Count;
        //    var counter = 0;
        //    foreach (var t in tokens)
        //    {
        //        var normalizedToken = t.ToLower().Trim();
        //        if (normalized.Contains(normalizedToken))
        //        {
        //            if (typeOfSearch == SearchType.Or) return true;
        //            counter++;
        //        }
        //    }
        //    return count == counter;
        //}

        public static string[] BreakUpQueryString(string query)
        {
            // Get the list of searchable tokens in the search string
            query = query.ToLower();
            query = query.ReplaceAny(" ", /* To be replaced */ ",", ";", "+", "*", "[", "]", "@");

            // Get the list of searchable tokens in the search string
            var tokens = query.ToLower().Split(' ');
            if (tokens.Length > 0)
            {
                tokens = tokens.Where(t => !t.IsNullOrWhitespace()).ToArray();
                return tokens;
            }
            return new[] { query };
        }
    }
}