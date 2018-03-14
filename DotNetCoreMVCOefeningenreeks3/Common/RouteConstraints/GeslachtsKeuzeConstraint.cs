using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using DotNetCoreMVCOefeningenreeks3.Models;

namespace DotNetCoreMVCOefeningenreeks3.Common.RouteConstraints
{
    public class GeslachtKeuzeConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return Enum.GetNames(typeof(Geslacht))
                        .Any(s => s.ToLowerInvariant() == values[parameterName].ToString().ToLowerInvariant());
        }
    }
}
