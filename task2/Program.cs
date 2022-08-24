// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("введите первое число");
int nomber1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int nomber2 = int.Parse(Console.ReadLine());
if (nomber1>nomber2)
{
    Console.WriteLine("Max=" + nomber1 + "," + "Min=" + nomber2);
}
else if (nomber2>nomber1)
{
    Console.WriteLine("Max=" + nomber2 + "," + "Min=" + nomber1);
}
else
{
    Console.WriteLine("числа равны");
}