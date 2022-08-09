//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите одно целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2) Console.WriteLine($"Нет чётных чисел в диапазоне от 1 до введенного числа.");

int count = 2;
while (num >= count)
{
    Console.Write($"{count} ");
    count = count + 2;
}
Console.WriteLine();