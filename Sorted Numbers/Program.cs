double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3  = double.Parse(Console.ReadLine());

if (num1 > num2 && num2 > num3)
{
    Console.WriteLine("Decending");
}
else if (num1 < num2 && num2 < num3)
{
    Console.WriteLine("Asending");
}
else
    Console.WriteLine("Not Sorted");