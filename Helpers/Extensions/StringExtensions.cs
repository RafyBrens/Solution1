using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Helpers.Extensions
{
    public static class StringExtensions
    {
        public static string SplitCameCase(this string input)
        {
            return Regex.Replace(input, "([A-Z])", "$1", RegexOptions.Compiled).Trim();
        }
    }
}
