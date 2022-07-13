// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)?

Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());
if (A % 2 == 0) {Console.WriteLine(A + " - это четноё число");}
else {Console.WriteLine(A + " - это нечетное число");}
