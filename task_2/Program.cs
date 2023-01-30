// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2

Console.Write("Введите первое число  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  ");
int b = Convert.ToInt32(Console.ReadLine());
int max;
int min;

if (a > b)
{
max = a; min = b;
}
else
{
     max = b; min = a;
}
Console.WriteLine($"Самое большее число {max}, а самое меньшее {min}!");