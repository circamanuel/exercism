
using System.Globalization;

public static class HighSchoolSweethearts
{
    private static readonly CultureInfo culture = System.Globalization.CultureInfo.GetCultureInfo("de-De");
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        return $"{studentA,29} ♡ {studentB,-29}";

    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        return
                @$"     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA} +  {studentB}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours) => $"{studentA} and {studentB} have been dating since {start:dd.MM.yyyy} - that's {hours.ToString("N2", culture)} hours";
}
