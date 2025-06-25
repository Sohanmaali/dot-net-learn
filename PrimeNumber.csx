Console.WriteLine("Enter A Number");
int number = int.Parse(Console.ReadLine());

for (int i = 2; i < number; i++)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Not A prime number");
        return;
    }
}
Console.WriteLine(" prime number");
