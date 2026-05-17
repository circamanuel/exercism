static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            _ when balance < 0 => 3.213f,
            _ when balance < 1000 => 0.5f, 
            _ when balance < 5000 => 1.621f,
            _ when balance >= 5000 => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        return balance switch
        {
            _ when balance < 0 => (decimal)(balance * 0.03213m),
            _ when balance < 1000 => (decimal)(balance * 0.005m),
            _ when balance < 5000 => (decimal)(balance * 0.01621m),
            _ when balance >= 5000 => (decimal)(balance * 0.02475m)
        };
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal startBalance = balance;
        int years = 0;

        while (startBalance < targetBalance)
        {

            startBalance = AnnualBalanceUpdate(startBalance);
            years++;
        }

        return years;
    }
}
