// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Программа нахождения максимального числа из трех.");

double number1, number2, number3, max;
Console.Write("Введите 1-е число: ");
number1 = max = double.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
number2 = double.Parse(Console.ReadLine());
Console.Write("Введите 3-е число: ");
number3 = double.Parse(Console.ReadLine());

if (max < number2)
{
  max = number2;
}
if (max < number3)
{
  max = number3;
}
Console.WriteLine($"Максимальное число: {max}");