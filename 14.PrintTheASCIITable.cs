using System;

class PrintTheASCIITable
{
    static void Main()
    {
        int column = 0;
        for (ushort counter = 0; counter < 256; counter++)
        {
            Console.Write("0x{0:X}  {1}  ", counter, (char)counter);
            if (++column > 7)
            {
                column = 0;
                Console.WriteLine();
            }

        }
    }
}
