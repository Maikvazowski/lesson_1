// Напишите программу, которая на вход принимает два числа и выдает,какое число больше, а какое меньше
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число, а ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число, b ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write($"a = {a}; b = {b} > max = {a}");
}
else
{
    Console.Write($"a = {a}; b = {b} > max = {b}");
}