using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object concaObject = firstString + " " + secondString;
        string thirdString = concaObject.ToString();
        Console.WriteLine(thirdString);
    }
}
