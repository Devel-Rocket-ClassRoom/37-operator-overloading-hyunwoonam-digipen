using System;
using System.Collections.Generic;
using System.Text;

struct Counter
{
    public int Value;

    public Counter(int value)
    {
        Value = value;
    }

    public static Counter operator -(Counter c)
    {
        return new Counter(-c.Value);
    }

    public static Counter operator ++(Counter c)
    {
        return new Counter(c.Value + 1);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

struct Fraction
{
    public int Numerator;
    public int Denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
        int newDenominator = a.Denominator * b.Denominator;

        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenominator = a.Denominator * b.Denominator;

        return new Fraction(newNumerator, newDenominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

struct Money
{
    public int Amount;
    public string Currency;

    public Money(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Amount == b.Amount && a.Currency == b.Currency;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }

    public static bool operator <(Money a, Money b)
    {
        return a.Amount < b.Amount;
    }

    public static bool operator >(Money a, Money b)
    {
        return a.Amount > b.Amount;
    }

    public override bool Equals(object obj)
    {
        if (obj is Money m)
        {
            return this == m;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}

struct Vector2
{
    public int X;
    public int Y;

    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

struct Celsius
{
    public double Value;

    public Celsius(double value)
    {
        Value = value;
    }

    public static implicit operator Celsius(double d)
    {
        return new Celsius(d);
    }

    public static implicit operator double(Celsius c)
    {
        return c.Value;
    }
}