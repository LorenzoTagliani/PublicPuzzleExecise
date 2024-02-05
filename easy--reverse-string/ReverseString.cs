using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var splittedReverdList = input.Reverse();
        var toString = splittedReverdList.ToString();
        var toStringDate = DateTime.Now.ToString();
        return new string(splittedReverdList.ToArray());
    }
}
