using System;
using System.Collections.Generic;
using System.Text;

struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;

    public GameTime(int hours, int minutes, int seconds)
    {
        this.Hours = hours;
        this.Minutes = minutes;
        this.Seconds = seconds;

        if (this.Seconds >= 60)
        {
            int temp = this.Seconds / 60;
            this.Seconds -= 60 * temp;
            this.Minutes += temp;
        }

        if (this.Minutes >= 60)
        {
            int temp = this.Minutes / 60;
            this.Minutes -= 60 * temp;
            this.Hours += temp;
        }

    }

    public int GetTotalSeconds()
    {
        int m = (Hours * 60) + Minutes;
        return (m * 60) + Seconds;
    }

    public static GameTime operator +(GameTime g1, GameTime g2)
    {
        return new GameTime(0,0,g1.GetTotalSeconds()+g2.GetTotalSeconds());
    }

    public static GameTime operator -(GameTime a, GameTime b)
    {
        int diff = a.GetTotalSeconds() - b.GetTotalSeconds();
        return new GameTime(0, 0, Math.Max(0, diff));
    }
    public static GameTime operator *(GameTime a, int multiplier)
    {
        return new GameTime(0, 0, a.GetTotalSeconds() * multiplier);
    }
    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds() == b.GetTotalSeconds(); ;
    }
    public static bool operator !=(GameTime g1, GameTime g2)
    {
        return !(g1 == g2);
    }

    public static bool operator <(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds() < b.GetTotalSeconds();
    }

    public static bool operator >(GameTime a, GameTime b)
    {
        return a.GetTotalSeconds() > b.GetTotalSeconds();
    }

    public override bool Equals(object obj)
    {
        if (obj is GameTime other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Hours, Minutes, Seconds);
    }

    public override string ToString()
    {
        return $"{Hours}h {Minutes}m {Seconds}s";
    }
}
