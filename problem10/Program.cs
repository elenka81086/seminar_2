/*Напишите программу, которая на вход принимает трёхзначное число 
и на выходе показывает вторую цифру этого цикла*/

int RandomNumber(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int ThreeDigitNumber(int number)
{
    int FirstNunber = number / 100;
    int SecondNumber = number / 10;
    int resalt = SecondNumber - FirstNunber * 10;
    return resalt;
}
int randomNumber = RandomNumber(100, 999);
int NumberTwo = ThreeDigitNumber(randomNumber);
Console.WriteLine($"Для случайного трехзначного числа {randomNumber} второй цифрой является {NumberTwo}");
