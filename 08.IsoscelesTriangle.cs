using System;

class IsoscelesTriangle
{
    static void Main()
    {
        int n = 4;
        int spaBef = n-1;
        int spaMid = 1;
        char copyR ='\u00A9';
        Console.Write(new string(' ', spaBef));
        Console.Write(copyR);
        Console.WriteLine();
        spaBef--;
        do
        {
            Console.Write(new string(' ', spaBef));
            Console.Write(copyR);
            Console.Write(new string (' ', spaMid));
            Console.Write(copyR);
            spaBef--;
            spaMid+=2;
            Console.WriteLine();
        }
        while (spaBef>0);
        Console.Write(copyR + " " + copyR + " " + copyR + " " + copyR);
        Console.WriteLine();
    }
}
