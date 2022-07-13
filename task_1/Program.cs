// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите любое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите любое число");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("максимальное число = "+ num1 );
    Console.WriteLine("минимальное число = "+ num2 );
}
else 
{
    Console.WriteLine("максимальное число = "+ num2 );
    Console.WriteLine("минимальное число = "+ num1 );
}