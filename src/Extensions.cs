using System;
using System.Globalization;
using System.Web;

namespace CoolRunner.SDK
{
    internal static class StringExtensions
    {
        public static Uri FormatUri(this string pattern, params object[] args) => new Uri(string.Format(CultureInfo.InvariantCulture, pattern, args), UriKind.Relative);

        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <returns>Url with added parameter.</returns>
        public static Uri AddParameter(this Uri uri, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }
    }
}
