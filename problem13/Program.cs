/* Напишите программу которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.*/
int number = new Random().Next(1, 2000);

Console.WriteLine($"Случайное число: {number}");

if (number / 100 < 1) 
Console.WriteLine($"Для числа {number} третья цифра отсутствует");
else
{
    if (number / 1000 > 0)
    {
        Console.WriteLine($"Для числа {number} третьей цифрой является {number / 10 % 10}");
    }
    else 
    Console.WriteLine($"Для числа {number} третьей цифрой является {number % 10}");
}
Console.WriteLine();