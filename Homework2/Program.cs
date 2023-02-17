/* Задача 13: Напишите программу, которая выводит третью цифру заданного
числа или сообщает, что третьей цифры нет.   645 -> 5  /  78 -> третьей цифры нет   /  32679 -> 6   */

/*
Console.Clear();
Console.WriteLine("1й способ");
int num = new Random().Next(1, 10000);
Console.WriteLine($"Введенное число: {num}");
//int num = 10;
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    while (num > 1000)
    {
      num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine($"цифра {result} - третья цифра заданного числа");
}
else
{
    Console.WriteLine("В заданном числе третьей цифры нет");
}
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("2й способ"); // чз строковое преобразование

        Console.Write("Введите число: ");
        string Array = Console.ReadLine();

        if (Array.Length < 3)
        {
            Console.WriteLine($"третья цифра отсутствует");
        }
        else
            Console.WriteLine($"{Array[2]} - третья цифра заданного числа");
    }
}
