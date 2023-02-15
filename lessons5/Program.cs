// Напишите программу, которая приимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> да / -4, 16 -> да / 25, 5 -> да / 8, 9 -> нет

/* Console.Write("Введите число1: ");
Double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число2: ");
Double num2 = Convert.ToDouble(Console.ReadLine());
if (Math.Sqrt(Math.Abs(num1)) == Math.Abs(num2) || Math.Sqrt(Math.Abs(num2)) == Math.Abs(num1)) // Math.Abs т.к.учесть из отриц.корень
{
    Console.WriteLine($"{num1}, {num2} одно из чисел является квадратом другого");    
}
else
{
    Console.WriteLine($"{num1}, {num2} -> не является");
}
*/

Console.Write("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(num1, 2) == num2 || Math.Pow(num2) == num1)
{
    Console.WriteLine($"{num1}, {num2} одно из чисел является квадратом другого");    
}
else
{
    Console.WriteLine($"{num1}, {num2} -> не является");
}