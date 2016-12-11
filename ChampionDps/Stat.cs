
enum StatType
{
    AP,
    AD,
    BonusAD,
    HP,
    Armor,
    MR,
    Resource,
    CDR
}

class Stat
{
    public Stat(double newBase, double newPerLevel)
    {
        BaseStat = newBase;
        PerLevel = newPerLevel;
    }

    public double GetValue(int level)
    {
        return baseStat + perLevel * level;
    }

    public double GetValue()
    {
        return GetValue(1);
    }

    public double BaseStat
    {
        get
        {
            return baseStat;
        }

        set
        {
            baseStat = value;
        }
    }

    public double PerLevel
    {
        get
        {
            return perLevel;
        }

        set
        {
            perLevel = value;
        }
    }

    private double baseStat;
    private double perLevel;
}