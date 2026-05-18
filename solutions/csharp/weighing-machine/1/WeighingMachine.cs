class WeighingMachine
{

    private double _weight;
    public int Precision { get; }  

    // TODO: define the 'Weight' property
    public double Weight { get => _weight; set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _weight = value;
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5d;
                

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight => $"{(Weight - TareAdjustment).ToString("F" + Precision)} kg";


    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

}
