using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    // https://learn.microsoft.com/it-it/dotnet/api/system.string?view=net-8.0  ---> metodi

    public static string Clean(string phoneNumber)
    {
        if (phoneNumber.Length >= 10)
        {
            throw new ArgumentException();
        } 
        else
        {
            if (phoneNumber.Length == 11 && phoneNumber[0] != '1')
            {
                throw new ArgumentException();
            }
            else
            {
                return String.Join("", phoneNumber.Split('1', '(', ')', '-', '.', ' '));
            }
        }
        return String.Join("", phoneNumber.Split('(', ')', '-', '.', ' '));
    }
}
