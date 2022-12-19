Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }
    Console.WriteLine(number % 10);
}
