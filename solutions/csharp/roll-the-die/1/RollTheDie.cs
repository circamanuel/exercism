
public class Player
{
    Random random = new Random();

    public int RollDie() => random.Next(1, 19);


    public double GenerateSpellStrength() => 0 + 99 * random.NextDouble();
}
