using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Numerics;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == null)
        {
            throw new ArgumentNullException();
        }
        if (operation == "-")
        {
            throw new ArgumentOutOfRangeException();
        }
        if (operation == "")
        {
           throw new ArgumentException();
        }


        try
        {
            string result = operation switch
            {
                "+" => $"{operand1 + operand2}",
                "*" => $"{operand1 * operand2}",
                "/" => $"{operand1 / operand2}",
                _ => throw new ArgumentOutOfRangeException()
            };
            //if (operation == "/" && operand2 == 0)
            //{
            //    throw new DivideByZeroException();
            //}

            return $"{operand1} {operation} {operand2} = {result}";
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }

    }
}
