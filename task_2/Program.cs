// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("введите число");
int C = int.Parse(Console.ReadLine());

if (A > B && A > C)
{Console.WriteLine("MAX number = " + A);}

else if (B > C) {Console.WriteLine("MAX number = " + B);}

else {Console.WriteLine("MAX number = " + C);}