class RemoteControlCar
{
    private int _meters = 0;
    private int _percentage = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if (_percentage > 0)
        {
            return $"Battery at {_percentage}%";
        }

        return "Battery empty";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (_percentage > 0)
        {
            _meters += 20;
            _percentage -= 1;
        }
        
        //throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
