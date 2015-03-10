class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        ushort age = Convert.ToUInt16(Console.ReadLine());
        string gender = Console.ReadLine();
        uint idNum = Convert.ToUInt32(Console.ReadLine());
        ulong empNum = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine("Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("ID Number: " + idNum);
        Console.WriteLine("Unique Employee Number: " + empNum);
    }
}
