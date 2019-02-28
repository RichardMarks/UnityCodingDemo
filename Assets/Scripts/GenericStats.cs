using System;

[Serializable]
public class GenericStats
{
    public int attack = 1;
    public int defense = 1;

    public GenericStats(int atk, int def)
    {
        attack = atk;
        defense = def;
    }
}
