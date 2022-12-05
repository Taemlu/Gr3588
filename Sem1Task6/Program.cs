//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

string? input1 = Console.ReadLine();

if (input1 != null)
{
    int num1 = int.Parse(input1);

    int remainder = num1 % 2; // введём переменную - остаток от деления на 2. Проверка на четность. Если ноль, то чётное.

    if (remainder == 0)
    {
        Console.WriteLine("Чётное");
    }
    else
    {
        Console.WriteLine("Нечётное");
    }

}