// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4   /  16, 4 -> кратно

/* Console.Clear();
int num1 = new Random().Next(100, 1000);
int num2 = new Random().Next(1, 10);
Console.WriteLine($" число1 {num1}");
Console.WriteLine($" число2 {num2}");
if (num1 % num2 == 0)
        {
              Console.WriteLine($" число {num1} кратно числу {num2}");
        }
else      
        {
                Console.WriteLine($" число {num1} не кратно числу {num2} остаток от деления: {num1 % num2}");
        }

*/



// тоже но со счетчиком к-ва перебора чисел 

Console.Clear();
while (1==1) // зациклено на кратности для подсчета к-ва переборов в 15 ставим break
{
int num1 = new Random().Next(100, 1000);
int num2 = new Random().Next(1, 10);
Console.WriteLine($" число1 {num1}");
Console.WriteLine($" число2 {num2}");
if (num1 % num2 == 0)
        {
              Console.WriteLine($" число {num1} кратно числу {num2}");
              break;
        }
else if (num1 % num2 != 0)
        {
              Console.WriteLine($" число {num1} не кратно числу {num2} остаток от деления: {num1 % num2}");
        }
} 