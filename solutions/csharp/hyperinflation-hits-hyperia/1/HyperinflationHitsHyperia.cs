public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        string result;
        
        try
        {
            result = checked((@base * multiplier).ToString());
        }
        catch (OverflowException ex)
        {
            result = "*** Too Big ***";
        }
        return result;
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        string result;

        try
        {
            result = checked((long)(@base * multiplier)).ToString();
        }
        catch (OverflowException ex)
        {
            result = "*** Too Big ***";
        }

        return result;
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        string result;
        
        try
        {
            result = checked(salaryBase * multiplier).ToString();
        }
        catch (OverflowException ex)
        {
            result = "*** Much Too Big ***";
        }
        return result;
    }
}
