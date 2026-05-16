public static class Identifier
{
    public static string Clean(string identifier)
    {
        string cleanString = "";
        bool kebabCase = false;

        //if (identifier.Equals("my\0Id"))
        //{
        //    return "myCTRLId";
        //}
        
        foreach (char c in identifier)
        {
            if (Char.IsWhiteSpace(c))
            {
                cleanString += "_";
            }
            else if (c.Equals('-'))
            {
                kebabCase = true;
            }
            else if (Char.IsControl(c)) 
            {
                cleanString += "CTRL"; 
            }
            else
            {
                if (kebabCase)
                {
                    cleanString += Char.ToUpper(c);
                    kebabCase = false;
                }
                else if (Char.IsLetter(c) && !(c >= '\u03B1' && c <= '\u03C9'))
                {
                    cleanString += c;
                }
            }

        }

        return cleanString;

        throw new NotImplementedException($"Please implement the (static) Identifier.Clean() method");
    }
}
