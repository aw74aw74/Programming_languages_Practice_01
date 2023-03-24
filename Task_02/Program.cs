// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Программа сравнения двух чисел.");
Console.Write("Введите 1-е число: ");
double number1;
number1 = double.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
double number2;
number2 = double.Parse(Console.ReadLine());
if (number1 > number2)
{
  Console.WriteLine($"Число {number1} больше числа {number2}");
}
else if (number1 < number2)
{
  Console.WriteLine($"Число {number1} меньше числа {number2}");
}
else
{
  Console.WriteLine($"Число {number1} равно числу {number2}");
}