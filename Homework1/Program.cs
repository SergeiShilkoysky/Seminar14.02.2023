// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 6 -> да  /  7 -> да  /  1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numWeek = Convert.ToInt32(Console.ReadLine());

if (numWeek == 6 || numWeek == 7)
{
    Console.WriteLine($"этот день ВЫХОДНОЙ !!!");
}
else if (numWeek ==1 || numWeek == 2 || numWeek == 3 || numWeek == 4 || numWeek == 5)
{
    Console.WriteLine(":( будни...");
}
else
{
    Console.WriteLine("Введите правильный номер");
}
