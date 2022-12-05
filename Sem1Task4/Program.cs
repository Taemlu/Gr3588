//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

string? input1 = Console.ReadLine(); //введем значения переменных типа "строка"
string? input2 = Console.ReadLine();
string? input3 = Console.ReadLine();

if (input1 != null && input2 != null && input3 != null) //проверим, что значения не пустые
{
    int num1 = int.Parse(input1); // оператор Parse превращает наше число из строки в десятичное
    int num2 = int.Parse(input2);
    int num3 = int.Parse(input3);

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("максимальное число - " + num1);
    }
}
else
if (num2 > num1)
{
    if (num2 > num3)
    {
        Console.WriteLine("максимальное число - " + num2);
    }
}
else
if (num3 > num1)
{
    if (num3 > num2)
    {
        Console.WriteLine("максимальное число - " + num3);
    }
}
}

