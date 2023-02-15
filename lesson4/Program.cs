// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет / 46 -> нет / 161 -> да

Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 % 7 == 0) && (num1 % 23 == 0))
{
    Console.WriteLine($"число {num1} -> кратно и 7 и 23");
}
else
{
    Console.WriteLine($"число {num1} -> не кратно 7 и 23");
}