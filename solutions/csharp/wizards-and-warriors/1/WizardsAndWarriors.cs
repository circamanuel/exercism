using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
        throw new NotImplementedException("Please implement the Character.ToString() method");
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }

        return 6;
    }
}

class Wizard : Character
{
    bool spellPrepared = false;

    public Wizard() : base("Wizard")
    {
    }

    public override bool Vulnerable()
    {
        return (spellPrepared != true);
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared)
        {
            return 12;
        }

        return 3;
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }
}
