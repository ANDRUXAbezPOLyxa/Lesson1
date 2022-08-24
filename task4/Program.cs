// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("масимальное число ");
Console.WriteLine(max);
