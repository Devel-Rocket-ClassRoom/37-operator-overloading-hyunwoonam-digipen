using System;
using System.Numerics;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 명시적 변환");

    Celsius c = new Celsius(100);

    Fahrenheit f = (Fahrenheit)c;

    Console.WriteLine(c);
    Console.WriteLine(f);
}

Console.WriteLine();

{
    Console.WriteLine("2. 실전 예제: Vector3 구조체");

    Vector3 v1 = new Vector3(1, 2, 3);
    Vector3 v2 = new Vector3(4, 5, 6);

    Console.WriteLine(v1 + v2);
    Console.WriteLine(v1 - v2);
    Console.WriteLine(v1 * 2);
    Console.WriteLine(3 * v2);
    Console.WriteLine(-v1);
    Console.WriteLine(v1 == v2);
}
