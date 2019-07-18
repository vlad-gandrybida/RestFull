using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RestFull.Common.Enums;
using RestFull.Common.Enums.Restaurant;

namespace RestFull.Presentation.Web.Helpers
{
    public static class RestaurantHelper
    {
        public static HtmlString RestaurantStateBadge(this IHtmlHelper html, RestaurantState state)
        {
            string stateBadge = "";

            switch (state)
            {
                case RestaurantState.Unknown:
                    stateBadge = string.Format(Constants.BadgeMarkup, "secondary", RestaurantState.Unknown);
                    break;
                case RestaurantState.Open:
                    stateBadge = string.Format(Constants.BadgeMarkup, "success", RestaurantState.Open);
                    break;
                case RestaurantState.Close:
                    stateBadge = string.Format(Constants.BadgeMarkup, "danger", RestaurantState.Close);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }

            return new HtmlString(stateBadge);
        }
    }
}
