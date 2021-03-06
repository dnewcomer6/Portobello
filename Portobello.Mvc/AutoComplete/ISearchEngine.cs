﻿using System;
using System.Collections.Generic;

namespace Portobello.Mvc.AutoComplete
{
    public interface ISearchEngine
    {
        Boolean CanHandle(String[] token);

        IEnumerable<AutoCompleteItem> GetHints(String[] tokens, Int32 maxRows = 15, SearchType typeOfSearch = SearchType.Or);
    }
}