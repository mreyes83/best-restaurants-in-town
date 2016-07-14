using Nancy;
using System;
using System.Collections.Generic;

namespace BestRestaurantsInTown
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        }
    }
}
