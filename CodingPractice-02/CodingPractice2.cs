using System;
using System.Collections.Generic;
using System.Text;

struct Celsius
{
    public double Temperature;

    public Celsius(double temperature)
    {
        Temperature = temperature;
    }

    public static explicit operator Fahrenheit(Celsius c)
    {
        return new Fahrenheit(((c.Temperature * 9) / 5) + 32);
    }

    public override string ToString()
    {
        return $"{Temperature}°C";
    }
}

struct Fahrenheit
{
    public double Temperature;

    public Fahrenheit(double temperature)
    {
        Temperature = temperature;
    }

    public static explicit operator Celsius(Fahrenheit f)
    {
        return new Celsius(((f.Temperature - 32) * 5) / 9);
    }

    public override string ToString()
    {
        return $"{Temperature}°F";
    }
}

struct Vector3
{
    public int X;
    public int Y;
    public int Z;

    public Vector3(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Vector3 operator *(Vector3 v, int scalar)
    {
        return new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }

    public static Vector3 operator *(int scalar, Vector3 v)
    {
        return new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }
    public static Vector3 operator -(Vector3 v)
    {
        return new Vector3(-v.X, -v.Y, -v.Z);
    }

    public static bool operator ==(Vector3 a, Vector3 b)
    {
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }
    public static bool operator !=(Vector3 a, Vector3 b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector3 v)
        {
            return this == v;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}