//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number1 = int.Parse(Console.ReadLine() ?? "0");

if (number1 < 1000 && number1 > 99)
{
    int secondDigit = (number1 / 10) % 10;
    Console.WriteLine("Вторая цифра - " + secondDigit);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
