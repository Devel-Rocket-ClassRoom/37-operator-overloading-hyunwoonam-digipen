using System;
using System.Collections.Generic;
using System.Text;

struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int Gold, int Silver)
    {
        this.Gold = Gold;
        this.Silver = Silver;
        if(this.Silver >= 100)
        {
            int temp = this.Silver / 100;
            this.Silver -= 100 * temp;
            this.Gold += temp;
        }
    }

    public int GetTotalSilver()
    {
        return (Gold * 100) + Silver;
    }

    public static GameCurrency operator +(GameCurrency g1, GameCurrency g2)
    {
        return new GameCurrency(0, g1.GetTotalSilver() + g2.GetTotalSilver());
    }

    public static GameCurrency operator -(GameCurrency g1, GameCurrency g2)
    {
        int temp = g1.GetTotalSilver() - g2.GetTotalSilver();

        if(temp < 0)
        {
            temp = 0;
        }

        return new GameCurrency(0, temp);
    }

    public static bool operator ==(GameCurrency g1, GameCurrency g2)
    {
        return g1.GetTotalSilver() == g2.GetTotalSilver();
    }

    public static bool operator !=(GameCurrency g1, GameCurrency g2)
    {
        return !(g1 == g2);
    }

    public static bool operator <(GameCurrency a, GameCurrency b)
    {
        return a.GetTotalSilver() < b.GetTotalSilver();
    }

    public static bool operator >(GameCurrency a, GameCurrency b)
    {
        return a.GetTotalSilver() > b.GetTotalSilver();
    }

    public override bool Equals(object obj)
    {
        if (obj is GameCurrency other)
        {
            return this == other;
        }
        return false;
    }

    public  bool Equals(GameCurrency other)
    {
        return this == other; ;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Gold, Silver);
    }

    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }

}