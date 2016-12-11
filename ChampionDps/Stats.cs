
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

struct Stat
{
    public Stat(double newBase, double newPerLevel)
    {
        baseStat = newBase;
        perLevel = newPerLevel;
    }

    public double baseStat;
    public double perLevel;
}