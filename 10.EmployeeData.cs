class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        ushort age = Convert.ToUInt16(Console.ReadLine());
        char gender = Convert.ToChar(Console.ReadLine());
        uint idNum = Convert.ToUInt32(Console.ReadLine());
        ulong empNum = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine("Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: {0}", (gender=='m'?"male" :"female"));
        Console.WriteLine("ID Number: " + idNum);
        Console.WriteLine("Unique Employee Number: " + empNum);
    }
}
