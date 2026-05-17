using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        var existingList = NewList();
        existingList.Add("C#");
        existingList.Add("Clojure");
        existingList.Add("Elm");
        return existingList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        List<string> addToList = languages;
        addToList.Add(language);
        return addToList;
    } 


    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        return languages switch
        {
            _ when !languages.Any() => false,
            _ when languages[0] == "C#" => true,
            _ when ((languages.Count == 3 || languages.Count == 2) && languages[1] == "C#") => true,
            _ => false
        };
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        HashSet<string> set = new();

        return languages.All(set.Add);
    }
}
