class BankAccountData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string middleName = Console.ReadLine();
        string lastName = Console.ReadLine();
        decimal balance = Convert.ToDecimal(Console.ReadLine());
        string bankName = Console.ReadLine();
        string iban = Console.ReadLine();
        ulong cardNumber1 = Convert.ToUInt64(Console.ReadLine());
        ulong cardNumber2 = Convert.ToUInt64(Console.ReadLine());
        ulong cardNumber3 = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine("Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("First Credit Card Number: " + cardNumber1);
        Console.WriteLine("Second Credit Card Number: " + cardNumber2);
        Console.WriteLine("Third Credit Card Number: " + cardNumber3);
    }
}
