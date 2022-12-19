Console.Write("Input 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Incorrect input");
}
else
{
    Console.WriteLine(number / 10 % 10);
}
