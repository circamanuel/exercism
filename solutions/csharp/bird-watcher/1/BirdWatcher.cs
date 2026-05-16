class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdLasWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 };
        return birdLasWeek;
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];

        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
        //throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if ( day == 0) { return true; }
        }

        return false;
        //throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdsInTimePeriode = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            birdsInTimePeriode += birdsPerDay[i];
        }

        return birdsInTimePeriode;
        //throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
            {
                busyDays++;  
            }
        }

        return busyDays;
        //throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
