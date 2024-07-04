using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input) =>
        Regex.Matches(input, @"\p{L}")
            .Select(s => s.Value.ToLower())
            .Distinct()
            .Count() == 26;
}
