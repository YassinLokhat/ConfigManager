using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConfigModifier
{
    public static class ExtentionMethods
    {
        public static bool Like(this string source, string toSearch, bool allowRegEx = false, bool matchCase = false)
        {
            if (!allowRegEx)
                return matchCase ? source.Contains(toSearch) : source.ToLower().Contains(toSearch.ToLower());

            toSearch = toSearch.Replace("*", @"([a]|[^a])*").Replace("?", @"([a]|[^a])?").Replace("+", @"([a]|[^a])+").Replace("!", @"([a]|[^a])");

            Regex regex = new Regex(toSearch, matchCase ? RegexOptions.None : RegexOptions.IgnoreCase);

            return regex.IsMatch(source);
        }
    }
}
