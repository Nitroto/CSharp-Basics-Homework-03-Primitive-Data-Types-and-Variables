using System;

class ComparingFloats
{
    static void Main()
    {
        while (true)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double diff = Math.Abs(a - b);
            bool chk;
            if (diff < 0.000001)
            {
                chk = true;
                Console.WriteLine(chk);
            }
            else
            {
                chk = false;
                Console.WriteLine(chk);
            }
        }
    }
}
