Console.WriteLine("введите число A");
string numberAStr = Console.ReadLine();
Console.WriteLine("введите число B");
string numberBStr = Console.ReadLine();
int a = int.Parse(numberAStr);
int b = int.Parse(numberBStr);
if (a > b);
{
    Console.WriteLine("Max=A,Min=B");
}
else
{
    Console.WriteLine("Max=B,Min=A");
}