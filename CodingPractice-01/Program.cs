using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 단항 연산자");

    Counter c = new Counter(5);

    Console.WriteLine(-c);
    c++;
    Console.WriteLine(c);
}

Console.WriteLine();

{
    Console.WriteLine("2. 이항 연산자");

    Fraction f1 = new Fraction(1, 2);
    Fraction f2 = new Fraction(1, 3);

    Console.WriteLine(f1 + f2);
    Console.WriteLine(f1 * f2);
}

Console.WriteLine();

{
    Console.WriteLine("3. 비교 연산자");

    Money m1 = new Money(1000, "KRW");
    Money m2 = new Money(2000, "KRW");


    Console.WriteLine(m1 == m2);
    Console.WriteLine(m1 < m2);
}

Console.WriteLine();

{
    Console.WriteLine("4. 복합 대입 연산자");

    Vector2 v = new Vector2(1, 2);

    v += new Vector2(3, 4);

    Console.WriteLine(v);
}

Console.WriteLine();


{
    Console.WriteLine("5. 암시적 변환");

    Celsius temp = 36.5;

    double value = temp;

    Console.WriteLine(value);
}