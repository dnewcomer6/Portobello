using System.Web;
using System.Web.Routing;
using AutoComplete.Common;
using AutoComplete.Models;
using Expoware.Portobello.AutoComplete;

namespace AutoComplete
{
    public class MvcApplication : HttpApplication
    {
        public static IAutoCompleteEngine IndexEngine1 { get; set; }
        public static CollectionSearchEngine<Country> IndexEngine2 { get; set; }

        protected void Application_Start()
        {
            IndexEngine1 = AutoCompleteConfig.IndexEngine1();
            IndexEngine2 = AutoCompleteConfig.IndexEngine2();

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
