// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar 
{
    int DistanceTravelled { get; }
    void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get;  private set; }
    public int NumberOfVictories { get; set; }

    public int CompareTo(ProductionRemoteControlCar? other)
    {
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }


    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> ascList = new List<ProductionRemoteControlCar>();

        if (prc1.NumberOfVictories > prc2.NumberOfVictories)
        {
            ascList.Add(prc2);
            ascList.Add(prc1);
        }
        else
        {
            ascList.Add(prc1);
            ascList.Add(prc2);
        }
        
        return ascList;
    }
}
