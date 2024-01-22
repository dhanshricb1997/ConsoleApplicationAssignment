Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("Num35");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Num3");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Num5");
    }
    else
    {
        Console.WriteLine("Number does not meet any condition.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid numeric value.");
}