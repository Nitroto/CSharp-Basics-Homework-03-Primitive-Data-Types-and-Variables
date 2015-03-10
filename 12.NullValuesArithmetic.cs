using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
        Console.WriteLine(intNull + 5);
        Console.WriteLine(doubleNull + 2.2);
    }
}
