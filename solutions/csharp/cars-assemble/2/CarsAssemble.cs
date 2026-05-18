static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0d,
            _ when speed <= 4 => 1d,
            _ when speed <= 8 => 0.9d,
            9 => 0.8d,
            10 => 0.77d
        };
    }

    public static double ProductionRatePerHour(int speed) => (speed * 221) * SuccessRate(speed);


    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
