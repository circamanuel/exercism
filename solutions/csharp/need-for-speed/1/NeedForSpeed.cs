using System.Runtime.CompilerServices;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain = 0;
    private int _distanceDriven = 0;
    private int _batteryDrained = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return ((_batteryDrained - _batteryDrain) < 0);

    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if ((_batteryDrained - _batteryDrain) >= 0)
        {
            _distanceDriven += _speed;
            _batteryDrained -= _batteryDrain;
        } 
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return _distance <= car.DistanceDriven();
    }
}
