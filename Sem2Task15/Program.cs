//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
double number = double.Parse(Console.ReadLine() ?? "0"); 
if(number>0&&number<8)
{
    if(number>5)
    {
        Console.WriteLine("Выходной");
    }
    else
    Console.WriteLine("Рабочий день");
}
else
Console.WriteLine("Вы ввели число не от 1 до 7.");